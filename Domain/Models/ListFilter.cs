namespace Samauma.Domain.Models
{
    public abstract class ListFilter
    {
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public bool? RequiredTotal { get; set; }
    }
}
