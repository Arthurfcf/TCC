﻿using Data.Context;
using Domain.Interfaces.Services.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService >();
        }
    }
}
