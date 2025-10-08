using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    public class ActivityLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string UserRole { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Action { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string? EntityType { get; set; } // e.g., "Quote", "User", "System"

        public int? EntityId { get; set; } // ID of the affected entity

        [MaxLength(500)]
        public string? Details { get; set; } // JSON or additional details

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [MaxLength(45)]
        public string? IpAddress { get; set; }

        [MaxLength(500)]
        public string? UserAgent { get; set; }

        // Navigation properties
        [NotMapped]
        public string FormattedTimestamp => Timestamp.ToString("MMM dd, yyyy HH:mm:ss");

        [NotMapped]
        public string ActionIcon => GetActionIcon();

        [NotMapped]
        public string ActionColor => GetActionColor();

        private string GetActionIcon()
        {
            return Action.ToLower() switch
            {
                var a when a.Contains("create") || a.Contains("add") => "bi-plus-circle",
                var a when a.Contains("update") || a.Contains("edit") || a.Contains("modify") => "bi-pencil-square",
                var a when a.Contains("delete") || a.Contains("remove") => "bi-trash",
                var a when a.Contains("view") || a.Contains("read") => "bi-eye",
                var a when a.Contains("login") => "bi-box-arrow-in-right",
                var a when a.Contains("logout") => "bi-box-arrow-right",
                var a when a.Contains("role") || a.Contains("permission") => "bi-person-gear",
                var a when a.Contains("export") => "bi-download",
                var a when a.Contains("import") => "bi-upload",
                var a when a.Contains("bulk") => "bi-collection",
                var a when a.Contains("status") => "bi-arrow-repeat",
                _ => "bi-activity"
            };
        }

        private string GetActionColor()
        {
            return Action.ToLower() switch
            {
                var a when a.Contains("create") || a.Contains("add") => "text-success",
                var a when a.Contains("update") || a.Contains("edit") || a.Contains("modify") => "text-warning",
                var a when a.Contains("delete") || a.Contains("remove") => "text-danger",
                var a when a.Contains("view") || a.Contains("read") => "text-info",
                var a when a.Contains("login") => "text-success",
                var a when a.Contains("logout") => "text-secondary",
                var a when a.Contains("role") || a.Contains("permission") => "text-primary",
                var a when a.Contains("export") => "text-info",
                var a when a.Contains("import") => "text-warning",
                var a when a.Contains("bulk") => "text-primary",
                _ => "text-secondary"
            };
        }
    }
}
