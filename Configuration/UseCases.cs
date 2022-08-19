﻿using Samauma.UseCases;
using Samauma.UseCases.AdministratorLogin;
using Samauma.UseCases.ListUsers;
using Samauma.UseCases.ListTrees;
using Samauma.UseCases.CreateTree;
using Samauma.UseCases.GetTreeById;
using Samauma.UseCases.UserDetail;
using Samauma.UseCases.DeleteTree;

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

        }
    }
}

