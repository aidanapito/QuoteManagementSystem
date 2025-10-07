using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    public class Quote
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string CustomerName { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }
        
        public int Quantity { get; set; }
        
        [NotMapped]
        public decimal TotalPrice => UnitPrice * Quantity;
        
        [Required]
        public DateTime CreatedDate { get; set; }
        
        [Required]
        public DateTime ValidQuotePeriod { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Status { get; set; } = "Draft";
        
        [MaxLength(1000)]
        public string Comments { get; set; } = string.Empty;
    }
}