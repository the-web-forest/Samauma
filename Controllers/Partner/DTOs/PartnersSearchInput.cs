using Samauma.Domain.Models;

namespace Samauma.Controllers.Partner.DTOs
{
    public class PartnersSearchInput : ListFilter
    {
        public string? Name { get; set; }
        public int? Code { get; set; }
        public string? Email { get; set; }
        public string? Url { get; set; }
    }
}
