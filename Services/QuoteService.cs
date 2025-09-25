using TestApp.Models;

namespace TestApp.Services
{
    public class QuoteService
    {
        private static List<Quote> _quotes = new List<Quote>
        {
            new Quote { Id = 1, CustomerName = "Acme Corp", ProductName = "Widget A", UnitPrice = 25.00m, Quantity = 10, CreatedDate = DateTime.Now.AddDays(-5), Status = "Draft" },
            new Quote { Id = 2, CustomerName = "Tech Solutions", ProductName = "Widget B", UnitPrice = 45.50m, Quantity = 5, CreatedDate = DateTime.Now.AddDays(-3), Status = "Pending" },
            new Quote { Id = 3, CustomerName = "Global Industries", ProductName = "Widget C", UnitPrice = 15.75m, Quantity = 20, CreatedDate = DateTime.Now.AddDays(-1), Status = "Approved" },
            new Quote { Id = 4, CustomerName = "StartUp Inc", ProductName = "Widget D", UnitPrice = 35.25m, Quantity = 8, CreatedDate = DateTime.Now.AddDays(-2), Status = "Draft" }
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
                existingQuote.Status = updatedQuote.Status;
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
            
            _quotes.Add(newQuote);
        }

        // TODO: Implement the following methods
        // (All methods now implemented)
    }
}