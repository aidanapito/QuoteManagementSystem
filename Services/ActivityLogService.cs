using Microsoft.EntityFrameworkCore;
using TestApp.Data;
using TestApp.Models;

namespace TestApp.Services
{
    public class ActivityLogService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ActivityLogService(ApplicationDbContext context, UserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task LogActivityAsync(string action, string? description = null, string? entityType = null, int? entityId = null, string? details = null)
        {
            try
            {
                var user = _userService.GetCurrentUser();
                var httpContext = _httpContextAccessor.HttpContext;

                var activityLog = new ActivityLog
                {
                    UserName = user.FullName,
                    UserRole = user.Role.ToString(),
                    Action = action,
                    Description = description,
                    EntityType = entityType,
                    EntityId = entityId,
                    Details = details,
                    Timestamp = DateTime.UtcNow,
                    IpAddress = GetClientIpAddress(httpContext),
                    UserAgent = GetUserAgent(httpContext)
                };

                _context.ActivityLogs.Add(activityLog);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the error but don't throw - we don't want logging failures to break the main functionality
                Console.WriteLine($"Failed to log activity: {ex.Message}");
            }
        }

        public async Task<PagedResult<ActivityLog>> GetActivityLogsPagedAsync(int page = 1, int pageSize = 20, string? searchTerm = null, string? actionFilter = null, string? userFilter = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            var query = _context.ActivityLogs.AsQueryable();

            // Apply filters
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(log => 
                    log.Action.Contains(searchTerm) ||
                    log.Description!.Contains(searchTerm) ||
                    log.UserName.Contains(searchTerm) ||
                    log.EntityType!.Contains(searchTerm));
            }

            if (!string.IsNullOrEmpty(actionFilter))
            {
                query = query.Where(log => log.Action == actionFilter);
            }

            if (!string.IsNullOrEmpty(userFilter))
            {
                query = query.Where(log => log.UserName == userFilter);
            }

            if (dateFrom.HasValue)
            {
                query = query.Where(log => log.Timestamp >= dateFrom.Value);
            }

            if (dateTo.HasValue)
            {
                query = query.Where(log => log.Timestamp <= dateTo.Value);
            }

            // Get total count
            var totalCount = await query.CountAsync();

            // Apply pagination and ordering
            var logs = await query
                .OrderByDescending(log => log.Timestamp)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<ActivityLog>
            {
                Items = logs,
                TotalCount = totalCount,
                PageNumber = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
            };
        }

        public async Task<List<string>> GetDistinctActionsAsync()
        {
            return await _context.ActivityLogs
                .Select(log => log.Action)
                .Distinct()
                .OrderBy(action => action)
                .ToListAsync();
        }

        public async Task<List<string>> GetDistinctUsersAsync()
        {
            return await _context.ActivityLogs
                .Select(log => log.UserName)
                .Distinct()
                .OrderBy(user => user)
                .ToListAsync();
        }

        public async Task<Dictionary<string, int>> GetActivityStatsAsync(DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _context.ActivityLogs.AsQueryable();

            if (fromDate.HasValue)
                query = query.Where(log => log.Timestamp >= fromDate.Value);

            if (toDate.HasValue)
                query = query.Where(log => log.Timestamp <= toDate.Value);

            return await query
                .GroupBy(log => log.Action)
                .Select(g => new { Action = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.Action, x => x.Count);
        }

        public async Task<List<ActivityLog>> GetRecentActivityAsync(int count = 10)
        {
            return await _context.ActivityLogs
                .OrderByDescending(log => log.Timestamp)
                .Take(count)
                .ToListAsync();
        }

        private string? GetClientIpAddress(HttpContext? context)
        {
            if (context == null) return null;

            // Check for forwarded IP first (in case of proxy/load balancer)
            var forwardedFor = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (!string.IsNullOrEmpty(forwardedFor))
            {
                return forwardedFor.Split(',')[0].Trim();
            }

            var realIp = context.Request.Headers["X-Real-IP"].FirstOrDefault();
            if (!string.IsNullOrEmpty(realIp))
            {
                return realIp;
            }

            return context.Connection.RemoteIpAddress?.ToString();
        }

        private string? GetUserAgent(HttpContext? context)
        {
            return context?.Request.Headers["User-Agent"].FirstOrDefault();
        }

        // Helper methods for common logging scenarios
        public async Task LogQuoteCreatedAsync(int quoteId, string customerName, string productName)
        {
            await LogActivityAsync(
                "Create Quote",
                $"Created quote #{quoteId} for {customerName} - {productName}",
                "Quote",
                quoteId,
                $"Customer: {customerName}, Product: {productName}"
            );
        }

        public async Task LogQuoteUpdatedAsync(int quoteId, string customerName, string productName)
        {
            await LogActivityAsync(
                "Update Quote",
                $"Updated quote #{quoteId} for {customerName} - {productName}",
                "Quote",
                quoteId,
                $"Customer: {customerName}, Product: {productName}"
            );
        }

        public async Task LogQuoteDeletedAsync(int quoteId, string customerName, string productName)
        {
            await LogActivityAsync(
                "Delete Quote",
                $"Deleted quote #{quoteId} for {customerName} - {productName}",
                "Quote",
                quoteId,
                $"Customer: {customerName}, Product: {productName}"
            );
        }

        public async Task LogBulkOperationAsync(string operation, int count, string? details = null)
        {
            await LogActivityAsync(
                $"Bulk {operation}",
                $"Performed bulk {operation.ToLower()} on {count} quotes",
                "Quote",
                null,
                details
            );
        }

        public async Task LogRoleChangeAsync(string fromRole, string toRole)
        {
            await LogActivityAsync(
                "Role Change",
                $"Changed role from {fromRole} to {toRole}",
                "User",
                null,
                $"From: {fromRole}, To: {toRole}"
            );
        }

        public async Task LogExportAsync(string format, int count)
        {
            await LogActivityAsync(
                "Export Data",
                $"Exported {count} quotes to {format.ToUpper()}",
                "System",
                null,
                $"Format: {format}, Count: {count}"
            );
        }

        public async Task LogImportAsync(string format, int count)
        {
            await LogActivityAsync(
                "Import Data",
                $"Imported {count} quotes from {format.ToUpper()}",
                "System",
                null,
                $"Format: {format}, Count: {count}"
            );
        }
    }
}
