using AutoMapper;

namespace Samauma.Configuration.AutoMapper
{
    public class ModelToDTOMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return GetType().Name; }
        }

        public ModelToDTOMappingProfile()
        {
            //CreateMap<PartnersSearchInput, ListPartnersUseCaseInput>();
        }
    }
}
