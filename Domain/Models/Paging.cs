namespace Samauma.Domain.Models
{
    public class Paging<T>
    {
        public IEnumerable<T> Data { get; set; }
        public long? TotalCount { get; set; }
    }
}
