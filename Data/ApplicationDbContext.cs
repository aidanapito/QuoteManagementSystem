using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Quote entity
            modelBuilder.Entity<Quote>(entity =>
            {
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(18,2)");
                
                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
                
                entity.Property(e => e.Comments)
                    .HasMaxLength(1000);
                
                entity.Property(e => e.CreatedDate)
                    .IsRequired();
                
                entity.Property(e => e.ValidQuotePeriod)
                    .IsRequired();
            });

            // Seed initial data
            modelBuilder.Entity<Quote>().HasData(
                new Quote 
                { 
                    Id = 1, 
                    CustomerName = "Acme Corp", 
                    ProductName = "Widget A", 
                    UnitPrice = 25.00m, 
                    Quantity = 10, 
                    CreatedDate = DateTime.Now.AddDays(-5), 
                    ValidQuotePeriod = DateTime.Now.AddDays(5), 
                    Status = "Draft", 
                    Comments = "Customer requested rush delivery" 
                },
                new Quote 
                { 
                    Id = 2, 
                    CustomerName = "Tech Solutions", 
                    ProductName = "Widget B", 
                    UnitPrice = 45.50m, 
                    Quantity = 5, 
                    CreatedDate = DateTime.Now.AddDays(-3), 
                    ValidQuotePeriod = DateTime.Now.AddDays(27), 
                    Status = "Pending", 
                    Comments = "" 
                },
                new Quote 
                { 
                    Id = 3, 
                    CustomerName = "Global Industries", 
                    ProductName = "Widget C", 
                    UnitPrice = 15.75m, 
                    Quantity = 20, 
                    CreatedDate = DateTime.Now.AddDays(-1), 
                    ValidQuotePeriod = DateTime.Now.AddDays(29), 
                    Status = "Approved", 
                    Comments = "" 
                },
                new Quote 
                { 
                    Id = 4, 
                    CustomerName = "StartUp Inc", 
                    ProductName = "Widget D", 
                    UnitPrice = 35.25m, 
                    Quantity = 8, 
                    CreatedDate = DateTime.Now.AddDays(-2), 
                    ValidQuotePeriod = DateTime.Now.AddDays(-1), 
                    Status = "Draft", 
                    Comments = "" 
                }
            );
        }
    }
}
