using AutoMapper;
using Samauma.UseCases.Interfaces.Repositories;
using Samauma.UseCases.PartnersUseCases.ListPartners.DTOs;

namespace Samauma.UseCases.PartnersUseCases.ListPartners
{
    public class ListPartnersUseCase : IUseCase<ListPartnersUseCaseInput, ListPartnersUseCaseOutput>
    {
        private readonly IMapper _mapper;
        IPartnerRepository _partnerRepository;

        public ListPartnersUseCase(
            IMapper mapper,
            IPartnerRepository partnerRepository)
        {
            _mapper = mapper;
            _partnerRepository = partnerRepository;
        }

        public async Task<ListPartnersUseCaseOutput> Run(ListPartnersUseCaseInput Input)
            => await _partnerRepository
                .GetPartnersByFilter(Input)
                .ContinueWith(partnersAndTotal => _mapper.Map<ListPartnersUseCaseOutput>(partnersAndTotal.Result));
    }
}
