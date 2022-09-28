using Samauma.External.Repositories;
using Samauma.UseCases.Interfaces;
using Samauma.UseCases.Interfaces.Repositories;

namespace Samauma.Configuration;

public static class Repositories
{
	public static void Configure(WebApplicationBuilder builder) {
		builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IAdministratorRepository, AdministratorRepository>();
		builder.Services.AddScoped<ITreeRepository, TreeRepository>();
		builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();
	}
}

