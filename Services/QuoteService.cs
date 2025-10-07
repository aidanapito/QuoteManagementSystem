using TestApp.Models;
using TestApp.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Services
{
    public class QuoteService
    {
        private readonly ApplicationDbContext _context;

        public QuoteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Quote>> GetAllQuotesAsync()
        {
            return await _context.Quotes.ToListAsync();
        }

        public async Task<Quote?> GetQuoteByIdAsync(int id)
        {
            return await _context.Quotes.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task UpdateQuoteAsync(Quote updatedQuote)
        {
            var existingQuote = await _context.Quotes.FirstOrDefaultAsync(q => q.Id == updatedQuote.Id);
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
                
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteQuoteAsync(int id)
        {
            var quoteToRemove = await _context.Quotes.FirstOrDefaultAsync(q => q.Id == id);
            if (quoteToRemove != null)
            {
                _context.Quotes.Remove(quoteToRemove);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AddQuoteAsync(Quote newQuote)
        {
            newQuote.CreatedDate = DateTime.Now;
            
            // Set default ValidQuotePeriod to 30 days from creation if not set
            if (newQuote.ValidQuotePeriod == DateTime.MinValue)
            {
                newQuote.ValidQuotePeriod = DateTime.Now.AddDays(30);
            }
            
            _context.Quotes.Add(newQuote);
            await _context.SaveChangesAsync();
        }

        // Synchronous methods for backward compatibility (will be deprecated)
        public List<Quote> GetAllQuotes()
        {
            return GetAllQuotesAsync().Result;
        }

        public Quote? GetQuoteById(int id)
        {
            return GetQuoteByIdAsync(id).Result;
        }

        public void UpdateQuote(Quote updatedQuote)
        {
            UpdateQuoteAsync(updatedQuote).Wait();
        }

        public void DeleteQuote(int id)
        {
            DeleteQuoteAsync(id).Wait();
        }

        public void AddQuote(Quote newQuote)
        {
            AddQuoteAsync(newQuote).Wait();
        }

        // CSV Export functionality
        public async Task<string> ExportToCsvAsync()
        {
            var quotes = await GetAllQuotesAsync();
            var csv = new StringBuilder();
            
            // Add header row
            csv.AppendLine("Id,CustomerName,ProductName,UnitPrice,Quantity,TotalPrice,CreatedDate,ValidQuotePeriod,Status,Comments");
            
            // Add data rows
            foreach (var quote in quotes)
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
        public async Task<int> ImportFromCsvAsync(string csvContent)
        {
            var lines = csvContent.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 2) return 0; // Need at least header + 1 data row
            
            var importedCount = 0;
            var quotes = new List<Quote>();
            
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
                            CustomerName = UnescapeCsvField(fields[1]),
                            ProductName = UnescapeCsvField(fields[2]),
                            UnitPrice = decimal.Parse(fields[3]),
                            Quantity = int.Parse(fields[4]),
                            CreatedDate = ParseDateTime(fields[6]),
                            ValidQuotePeriod = ParseDateTime(fields[7]),
                            Status = UnescapeCsvField(fields[8]),
                            Comments = fields.Length > 9 ? UnescapeCsvField(fields[9]) : ""
                        };
                        
                        quotes.Add(quote);
                        importedCount++;
                    }
                }
                catch (Exception ex)
                {
                    // Log error but continue processing other rows
                    Console.WriteLine($"Error importing row {i + 1}: {ex.Message}");
                }
            }
            
            // Add all quotes to database in one transaction
            if (quotes.Any())
            {
                _context.Quotes.AddRange(quotes);
                await _context.SaveChangesAsync();
            }
            
            return importedCount;
        }

        // Synchronous CSV methods for backward compatibility
        public string ExportToCsv()
        {
            return ExportToCsvAsync().Result;
        }

        public int ImportFromCsv(string csvContent)
        {
            return ImportFromCsvAsync(csvContent).Result;
        }

        private DateTime ParseDateTime(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
                return DateTime.Now;

            // Try multiple date formats
            string[] formats = {
                "yyyy-MM-dd HH:mm:ss",
                "yyyy-MM-dd",
                "MM/dd/yyyy HH:mm:ss",
                "MM/dd/yyyy",
                "dd/MM/yyyy HH:mm:ss",
                "dd/MM/yyyy",
                "yyyy/MM/dd HH:mm:ss",
                "yyyy/MM/dd"
            };

            if (DateTime.TryParseExact(dateString, formats, null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                return result;
            }

            // Fallback to standard parsing
            if (DateTime.TryParse(dateString, out result))
            {
                return result;
            }

            // If all else fails, return current date
            return DateTime.Now;
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