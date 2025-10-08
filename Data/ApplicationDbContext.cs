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

            // Seed initial data with lots of mock quotes
            var random = new Random(42); // Fixed seed for consistent data
            var customers = new[] { "Acme Corp", "Tech Solutions", "Global Industries", "StartUp Inc", "MegaCorp Ltd", "Innovation Co", "Future Systems", "Alpha Industries", "Beta Solutions", "Gamma Corp", "Delta Enterprises", "Epsilon Tech", "Zeta Manufacturing", "Eta Services", "Theta Group", "Iota Systems", "Kappa Corp", "Lambda Industries", "Mu Solutions", "Nu Technologies" };
            var products = new[] { "Widget A", "Widget B", "Widget C", "Widget D", "Premium Widget", "Standard Widget", "Deluxe Widget", "Basic Widget", "Pro Widget", "Enterprise Widget", "Custom Widget", "Special Widget", "Advanced Widget", "Super Widget", "Ultra Widget", "Mega Widget", "Giga Widget", "Tera Widget", "Peta Widget", "Exa Widget" };
            var statuses = new[] { "Draft", "Pending", "Approved", "Rejected" };
            var comments = new[] { "", "Rush delivery requested", "Standard processing", "Priority customer", "Bulk discount applied", "Custom configuration", "Expedited shipping", "Special pricing", "Volume discount", "Annual contract", "First-time customer", "VIP customer", "Emergency order", "Regular customer", "New product line" };

            var quotes = new List<Quote>();
            var id = 1;

            // Generate 100 mock quotes
            for (int i = 0; i < 100; i++)
            {
                var createdDate = DateTime.Now.AddDays(-random.Next(1, 365)); // Random date in past year
                var validUntil = createdDate.AddDays(random.Next(7, 90)); // Valid for 7-90 days
                
                quotes.Add(new Quote
                {
                    Id = id++,
                    CustomerName = customers[random.Next(customers.Length)],
                    ProductName = products[random.Next(products.Length)],
                    UnitPrice = Math.Round((decimal)(random.NextDouble() * 1000 + 10), 2), // $10-$1010
                    Quantity = random.Next(1, 100),
                    CreatedDate = createdDate,
                    ValidQuotePeriod = validUntil,
                    Status = statuses[random.Next(statuses.Length)],
                    Comments = comments[random.Next(comments.Length)]
                });
            }

            modelBuilder.Entity<Quote>().HasData(quotes.ToArray());
        }
    }
}
