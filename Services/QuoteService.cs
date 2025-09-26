using TestApp.Models;

namespace TestApp.Services
{
    public class QuoteService
    {
        private static List<Quote> _quotes = new List<Quote>
        {
            new Quote { Id = 1, CustomerName = "Acme Corp", ProductName = "Widget A", UnitPrice = 25.00m, Quantity = 10, CreatedDate = DateTime.Now.AddDays(-5), ValidQuotePeriod = DateTime.Now.AddDays(25), Status = "Draft", Comments = "Customer requested rush delivery" },
            new Quote { Id = 2, CustomerName = "Tech Solutions", ProductName = "Widget B", UnitPrice = 45.50m, Quantity = 5, CreatedDate = DateTime.Now.AddDays(-3), ValidQuotePeriod = DateTime.Now.AddDays(27), Status = "Pending", Comments = "" },
            new Quote { Id = 3, CustomerName = "Global Industries", ProductName = "Widget C", UnitPrice = 15.75m, Quantity = 20, CreatedDate = DateTime.Now.AddDays(-1), ValidQuotePeriod = DateTime.Now.AddDays(29), Status = "Approved", Comments = "" },
            new Quote { Id = 4, CustomerName = "StartUp Inc", ProductName = "Widget D", UnitPrice = 35.25m, Quantity = 8, CreatedDate = DateTime.Now.AddDays(-2), ValidQuotePeriod = DateTime.Now.AddDays(28), Status = "Draft", Comments = "" }
        };

        public List<Quote> GetAllQuotes()
        {
            return _quotes;
        }

        public Quote? GetQuoteById(int id)
        {
            return _quotes.FirstOrDefault(q => q.Id == id);
        }

        public void UpdateQuote(Quote updatedQuote)
        {
            var existingQuote = _quotes.FirstOrDefault(q => q.Id == updatedQuote.Id);
            if (existingQuote != null)
            {
                existingQuote.CustomerName = updatedQuote.CustomerName;
                existingQuote.ProductName = updatedQuote.ProductName;
                existingQuote.UnitPrice = updatedQuote.UnitPrice;
                existingQuote.Quantity = updatedQuote.Quantity;
                existingQuote.ValidQuotePeriod = updatedQuote.ValidQuotePeriod;
                existingQuote.Status = updatedQuote.Status;
                existingQuote.Comments = updatedQuote.Comments;
                // Note: CreatedDate and Id are not updated to maintain data integrity
            }
        }

        public void DeleteQuote(int id)
        {
            var quoteToRemove = _quotes.FirstOrDefault(q => q.Id == id);
            if (quoteToRemove != null)
            {
                _quotes.Remove(quoteToRemove);
            }
        }

        public void AddQuote(Quote newQuote)
        {
            // Generate next available ID
            var maxId = _quotes.Count > 0 ? _quotes.Max(q => q.Id) : 0;
            newQuote.Id = maxId + 1;
            newQuote.CreatedDate = DateTime.Now;
            
            // Set default ValidQuotePeriod to 30 days from creation if not set
            if (newQuote.ValidQuotePeriod == DateTime.MinValue)
            {
                newQuote.ValidQuotePeriod = DateTime.Now.AddDays(30);
            }
            
            _quotes.Add(newQuote);
        }

        // TODO: Implement the following methods
        // (All methods now implemented)
    }
}