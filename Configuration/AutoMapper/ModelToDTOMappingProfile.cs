using AutoMapper;
using Samauma.Domain.Models;
using Samauma.UseCases.PartnersUseCases.GetPartnerById;
using Samauma.UseCases.PartnersUseCases.ListPartners;
using Samauma.UseCases.PartnersUseCases.ListPartners.DTOs;

namespace Samauma.Configuration.AutoMapper
{
    public class ModelToDtoMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return GetType().Name; }
        }

        public ModelToDtoMappingProfile()
        {
            CreateMap<Partner, LightPartner>();

            CreateMap<Paging<Partner>, ListPartnersUseCaseOutput>()
                .ForMember(x => x.Partners, y => y.MapFrom(z => z.Data))
                .ForMember(x => x.TotalCount, y => y.MapFrom(z => z.TotalCount));

            CreateMap<Partner, GetPartnerByIdUseCaseOutput>();
        }
    }
}
