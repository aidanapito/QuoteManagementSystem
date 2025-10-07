namespace TestApp.Models
{
    public class QuoteFilter
    {
        public string? SearchTerm { get; set; }
        public string SortBy { get; set; } = "id-asc";
        public string? Customer { get; set; }
        public string? Product { get; set; }
        public string? Status { get; set; }
        public string DateRangeFilter { get; set; } = "all";
        public DateTime? CustomStartDate { get; set; }
        public DateTime? CustomEndDate { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? MinQuantity { get; set; }
        public int? MaxQuantity { get; set; }
        
        public bool HasActiveFilters()
        {
            return !string.IsNullOrWhiteSpace(Customer) ||
                   !string.IsNullOrWhiteSpace(Product) ||
                   !string.IsNullOrWhiteSpace(Status) ||
                   DateRangeFilter != "all" ||
                   MinPrice.HasValue ||
                   MaxPrice.HasValue ||
                   MinQuantity.HasValue ||
                   MaxQuantity.HasValue;
        }
    }
}
