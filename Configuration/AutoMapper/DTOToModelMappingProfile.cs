using AutoMapper;
using Samauma.Controllers.Partner.DTOs;
using Samauma.UseCases.PartnersUseCases.CreatePartners;
using Samauma.UseCases.PartnersUseCases.ListPartners;

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
        }
    }
}
