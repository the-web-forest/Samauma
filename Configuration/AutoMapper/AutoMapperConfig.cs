using System.Reflection;

namespace Samauma.Configuration.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(
                Assembly.GetAssembly(typeof(DtoToModelMappingProfile)),
                Assembly.GetAssembly(typeof(ModelToDtoMappingProfile)));
        }
    }
}
