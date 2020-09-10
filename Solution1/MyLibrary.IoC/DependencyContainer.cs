using Microsoft.Extensions.DependencyInjection;
using MyLibrary.Data.Repositories;
using MyLibrary.Domain.Interfaces;
using MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<ILog, MyConsoleLogger>();
            services.AddSingleton<ILog, MyTextFileLogger>();


            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
