using Samauma.UseCases.PartnersUseCases.ListPartners.DTOs;

namespace Samauma.UseCases.PartnersUseCases.ListPartners
{
    public class ListPartnersUseCaseOutput
    {
        public IEnumerable<LightPartner> Partners { get; set; }
        public long? TotalCount { get; set; }
    }
}
