namespace TestApp.Models
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
        
        public int StartIndex => (PageNumber - 1) * PageSize + 1;
        public int EndIndex => Math.Min(PageNumber * PageSize, TotalCount);
    }
}
