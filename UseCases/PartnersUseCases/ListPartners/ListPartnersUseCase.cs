using Samauma.UseCases.Interfaces.Repositories;
using Samauma.UseCases.PartnersUseCases.ListPartners.DTOs;

namespace Samauma.UseCases.PartnersUseCases.ListPartners
{
    public class ListPartnersUseCase : IUseCase<ListPartnersUseCaseInput, ListPartnersUseCaseOutput>
    {
        IPartnerRepository _partnerRepository;

        public ListPartnersUseCase(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public async Task<ListPartnersUseCaseOutput> Run(ListPartnersUseCaseInput Input)
            => await _partnerRepository
                .GetPartnersByFilter(Input)
                .ContinueWith(partnersAndTotal => new ListPartnersUseCaseOutput
                {
                    Partners = partnersAndTotal.Result.Data.Select(partner => new LightPartner(
                        partner.Name,
                        partner.Code,
                        partner.Email,
                        partner.Url
                    )),
                    TotalCount = partnersAndTotal.Result.TotalCount
                });
    }
}
