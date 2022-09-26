using AutoMapper;
using Samauma.Controllers.Partner.DTOs;
using Samauma.Domain.Models;
using Samauma.UseCases.PartnersUseCases.CreatePartners;
using Samauma.UseCases.PartnersUseCases.ListPartners;
using Samauma.UseCases.PartnersUseCases.UpdatePartner;

namespace Samauma.Configuration.AutoMapper
{
    public class DTOToModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return GetType().Name; }
        }

        public DTOToModelMappingProfile()
        {
            CreateMap<PartnersSearchInput, ListPartnersUseCaseInput>();
            CreateMap<CreatePartnerInput, CreatePartnerUseCaseInput>();
            CreateMap<CreatePartnerUseCaseInput, Partner>()
                .BeforeMap((s, d) => d.Deleted = false);
            CreateMap<UpdatePartnerInput, UpdatePartnerUseCaseInput>();
            CreateMap<UpdatePartnerUseCaseInput, Partner>()
                .ForMember(x => x.Id, y => y.Ignore())
                .ForMember(x => x.Code, y => y.Ignore())
                .ForAllMembers(x => x.Condition((src, dest, srcMember) => srcMember is not null));
        }
    }
}
