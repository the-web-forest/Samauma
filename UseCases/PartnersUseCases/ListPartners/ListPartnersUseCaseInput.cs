using Samauma.Domain.Models;

namespace Samauma.UseCases.PartnersUseCases.ListPartners
{
    public class ListPartnersUseCaseInput : ListFilter
    {
        public string? Name { get; set; }
        public int? Code { get; set; }
        public string? Email { get; set; }
        public string? Url { get; set; }
    }
}
