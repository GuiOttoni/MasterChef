using MasterChef.Application.Interfaces;
using MasterChef.Application.Services;
using MasterChef.Persistence.Contexts;
using MasterChef.Persistence.Repositories;
using MasterChef.Persistence.Repositories.Intefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            
            services.AddMemoryCache();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=MasterChef;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<DataContext>(option => option.UseSqlServer(connection));
            services.AddScoped<IRecipeRepository, RecipeRepository>();
        }
    }
}
