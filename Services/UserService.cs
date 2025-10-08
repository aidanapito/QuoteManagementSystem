using TestApp.Models;

namespace TestApp.Services
{
    public class UserService
    {
        // Simulated current user - in a real app, this would come from authentication
        private User _currentUser;

        public UserService()
        {
            // Default to Admin for demo purposes
            _currentUser = new User
            {
                Id = 1,
                Username = "admin",
                Email = "admin@example.com",
                FullName = "Admin User",
                Role = UserRole.Admin,
                IsActive = true,
                LastLoginDate = DateTime.Now
            };
        }

        public User GetCurrentUser()
        {
            return _currentUser;
        }

        public void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public bool HasPermission(Permission permission)
        {
            var userRole = _currentUser.Role;

            return permission switch
            {
                Permission.ViewQuotes => true, // All roles can view
                Permission.CreateQuotes => userRole >= UserRole.Sales,
                Permission.EditQuotes => userRole >= UserRole.Sales,
                Permission.DeleteQuotes => userRole >= UserRole.Manager,
                Permission.BulkOperations => userRole >= UserRole.Manager,
                Permission.ViewAnalytics => userRole >= UserRole.Sales,
                Permission.ViewActivityLogs => userRole >= UserRole.Manager,
                Permission.ManageUsers => userRole >= UserRole.Admin,
                Permission.ExportData => userRole >= UserRole.Manager,
                Permission.AdjustPrices => userRole >= UserRole.Manager,
                _ => false
            };
        }

        public string GetRoleDisplayName(UserRole role)
        {
            return role switch
            {
                UserRole.ViewOnly => "View Only",
                UserRole.Sales => "Sales",
                UserRole.Manager => "Manager",
                UserRole.Admin => "Administrator",
                _ => "Unknown"
            };
        }

        public string GetRoleBadgeClass(UserRole role)
        {
            return role switch
            {
                UserRole.ViewOnly => "bg-secondary",
                UserRole.Sales => "bg-primary",
                UserRole.Manager => "bg-warning text-dark",
                UserRole.Admin => "bg-danger",
                _ => "bg-secondary"
            };
        }

        public List<User> GetAllUsers()
        {
            // Demo users - in a real app, this would come from database
            return new List<User>
            {
                new User { Id = 1, Username = "admin", Email = "admin@example.com", FullName = "Admin User", Role = UserRole.Admin, IsActive = true, CreatedDate = DateTime.Now.AddMonths(-6), LastLoginDate = DateTime.Now },
                new User { Id = 2, Username = "manager1", Email = "manager@example.com", FullName = "John Manager", Role = UserRole.Manager, IsActive = true, CreatedDate = DateTime.Now.AddMonths(-4), LastLoginDate = DateTime.Now.AddHours(-2) },
                new User { Id = 3, Username = "sales1", Email = "sales1@example.com", FullName = "Jane Sales", Role = UserRole.Sales, IsActive = true, CreatedDate = DateTime.Now.AddMonths(-3), LastLoginDate = DateTime.Now.AddDays(-1) },
                new User { Id = 4, Username = "sales2", Email = "sales2@example.com", FullName = "Bob Salesperson", Role = UserRole.Sales, IsActive = true, CreatedDate = DateTime.Now.AddMonths(-2), LastLoginDate = DateTime.Now.AddDays(-3) },
                new User { Id = 5, Username = "viewer", Email = "viewer@example.com", FullName = "Guest Viewer", Role = UserRole.ViewOnly, IsActive = true, CreatedDate = DateTime.Now.AddMonths(-1), LastLoginDate = DateTime.Now.AddDays(-7) }
            };
        }
    }

    public enum Permission
    {
        ViewQuotes,
        CreateQuotes,
        EditQuotes,
        DeleteQuotes,
        BulkOperations,
        ViewAnalytics,
        ViewActivityLogs,
        ManageUsers,
        ExportData,
        AdjustPrices
    }
}

