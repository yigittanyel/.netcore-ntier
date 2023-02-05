using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.Repositories.Concrete;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using FishingApp.DataAccess.UnitOfWorks.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.DataAccess.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("cnnstr")));

            services.AddScoped<IBirimRepository, BirimRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
