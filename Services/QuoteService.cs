using TestApp.Models;
using System.Text;

namespace TestApp.Services
{
    public class QuoteService
    {
        private static List<Quote> _quotes = new List<Quote>
        {
            new Quote { Id = 1, CustomerName = "Acme Corp", ProductName = "Widget A", UnitPrice = 25.00m, Quantity = 10, CreatedDate = DateTime.Now.AddDays(-5), ValidQuotePeriod = DateTime.Now.AddDays(5), Status = "Draft", Comments = "Customer requested rush delivery" },
            new Quote { Id = 2, CustomerName = "Tech Solutions", ProductName = "Widget B", UnitPrice = 45.50m, Quantity = 5, CreatedDate = DateTime.Now.AddDays(-3), ValidQuotePeriod = DateTime.Now.AddDays(27), Status = "Pending", Comments = "" },
            new Quote { Id = 3, CustomerName = "Global Industries", ProductName = "Widget C", UnitPrice = 15.75m, Quantity = 20, CreatedDate = DateTime.Now.AddDays(-1), ValidQuotePeriod = DateTime.Now.AddDays(29), Status = "Approved", Comments = "" },
            new Quote { Id = 4, CustomerName = "StartUp Inc", ProductName = "Widget D", UnitPrice = 35.25m, Quantity = 8, CreatedDate = DateTime.Now.AddDays(-2), ValidQuotePeriod = DateTime.Now.AddDays(-1), Status = "Draft", Comments = "" }
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

        // CSV Export functionality
        public string ExportToCsv()
        {
            var csv = new StringBuilder();
            
            // Add header row
            csv.AppendLine("Id,CustomerName,ProductName,UnitPrice,Quantity,TotalPrice,CreatedDate,ValidQuotePeriod,Status,Comments");
            
            // Add data rows
            foreach (var quote in _quotes)
            {
                csv.AppendLine($"{quote.Id}," +
                              $"\"{EscapeCsvField(quote.CustomerName)}\"," +
                              $"\"{EscapeCsvField(quote.ProductName)}\"," +
                              $"{quote.UnitPrice}," +
                              $"{quote.Quantity}," +
                              $"{quote.TotalPrice}," +
                              $"{quote.CreatedDate:yyyy-MM-dd HH:mm:ss}," +
                              $"{quote.ValidQuotePeriod:yyyy-MM-dd HH:mm:ss}," +
                              $"\"{EscapeCsvField(quote.Status)}\"," +
                              $"\"{EscapeCsvField(quote.Comments)}\"");
            }
            
            return csv.ToString();
        }

        // CSV Import functionality
        public int ImportFromCsv(string csvContent)
        {
            var lines = csvContent.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 2) return 0; // Need at least header + 1 data row
            
            var importedCount = 0;
            var maxId = _quotes.Count > 0 ? _quotes.Max(q => q.Id) : 0;
            
            // Skip header row, process data rows
            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    var fields = ParseCsvLine(lines[i]);
                    if (fields.Length >= 9) // Ensure we have enough fields
                    {
                        var quote = new Quote
                        {
                            Id = ++maxId, // Generate new ID
                            CustomerName = UnescapeCsvField(fields[1]),
                            ProductName = UnescapeCsvField(fields[2]),
                            UnitPrice = decimal.Parse(fields[3]),
                            Quantity = int.Parse(fields[4]),
                            CreatedDate = DateTime.Parse(fields[6]),
                            ValidQuotePeriod = DateTime.Parse(fields[7]),
                            Status = UnescapeCsvField(fields[8]),
                            Comments = fields.Length > 9 ? UnescapeCsvField(fields[9]) : ""
                        };
                        
                        _quotes.Add(quote);
                        importedCount++;
                    }
                }
                catch (Exception ex)
                {
                    // Log error but continue processing other rows
                    Console.WriteLine($"Error importing row {i + 1}: {ex.Message}");
                }
            }
            
            return importedCount;
        }

        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            
            // Escape quotes by doubling them
            return field.Replace("\"", "\"\"");
        }

        private string UnescapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            
            // Remove surrounding quotes if present
            if (field.StartsWith("\"") && field.EndsWith("\""))
            {
                field = field.Substring(1, field.Length - 2);
            }
            
            // Unescape quotes
            return field.Replace("\"\"", "\"");
        }

        private string[] ParseCsvLine(string line)
        {
            var fields = new List<string>();
            var currentField = "";
            var inQuotes = false;
            
            for (int i = 0; i < line.Length; i++)
            {
                var c = line[i];
                
                if (c == '"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        // Escaped quote
                        currentField += '"';
                        i++; // Skip next quote
                    }
                    else
                    {
                        // Toggle quote state
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    // Field separator
                    fields.Add(currentField);
                    currentField = "";
                }
                else
                {
                    currentField += c;
                }
            }
            
            // Add the last field
            fields.Add(currentField);
            
            return fields.ToArray();
        }
    }
}