using Samauma.UseCases;
using Samauma.UseCases.AdministratorLogin;
using Samauma.UseCases.ListUsers;
using Samauma.UseCases.ListTrees;
using Samauma.UseCases.CreateTree;
using Samauma.UseCases.GetTreeById;
using Samauma.UseCases.UserDetail;
using Samauma.UseCases.DeleteTree;
using Samauma.UseCases.PartnersUseCases.ListPartners;
using Samauma.UseCases.PartnersUseCases.CreatePartners;
using Samauma.UseCases.PartnersUseCases.DeletePartner;
using Samauma.UseCases.PartnersUseCases.GetPartnerById;
using Samauma.UseCases.PartnersUseCases.UpdatePartner;

namespace Samauma.Configuration
{
	public static class UseCases
	{
		public static void Configure(WebApplicationBuilder builder)
        {
            #region User
            builder.Services.AddScoped<IUseCase<AdministratorLoginUseCaseInput, AdministratorLoginUseCaseOutput>, AdministratorLoginUseCase>();
            builder.Services.AddScoped<IUseCase<ListUsersUseCaseInput, ListUsersUseCaseOutput>, ListUsersUseCase>();
            builder.Services.AddScoped<IUseCase<UserDetailUseCaseInput, UserDetailUseCaseOutput>, UserDetailUseCase>();
            #endregion

            #region Tree
            builder.Services.AddScoped<IUseCase<UpdateTreeUseCaseInput, UpdateTreeUseCaseOutput>, UpdateTreeUseCase>();
            builder.Services.AddScoped<IUseCase<CreateTreeUseCaseInput, CreateTreeUseCaseOutput>, CreateTreeUseCase>();
            builder.Services.AddScoped<IUseCase<ListTreesUseCaseInput, ListTreesUseCaseOutput>, ListTreesUseCase>();
            builder.Services.AddScoped<IUseCase<GetTreeByIdUseCaseInput, GetTreeByIdUseCaseOutput>, GetTreeByIdUseCase>();
            builder.Services.AddScoped<IUseCase<DeleteTreeUseCaseInput, DeleteTreeUseCaseOutput>, DeleteTreeUseCase>();
            #endregion

            #region Partner
            builder.Services.AddScoped<IUseCase<ListPartnersUseCaseInput, ListPartnersUseCaseOutput>, ListPartnersUseCase>();
            builder.Services.AddScoped<IUseCase<CreatePartnerUseCaseInput, CreatePartnerUseCaseOutput>, CreatePartnerUseCase>();
            builder.Services.AddScoped<IUseCase<DeletePartnerUseCaseInput, DeletePartnerUseCaseOutput>, DeletePartnerUseCase>();
            builder.Services.AddScoped<IUseCase<GetPartnerByIdUseCaseInput, GetPartnerByIdUseCaseOutput>, GetPartnerByIdUseCase>();
            builder.Services.AddScoped<IUseCase<UpdatePartnerUseCaseInput, UpdatePartnerUseCaseOutput>, UpdatePartnerUseCase>();
            #endregion
        }
    }
}

