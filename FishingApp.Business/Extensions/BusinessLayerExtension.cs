using FishingApp.Business.Services.Abstract;
using FishingApp.Business.Services.Concrete;
using FishingApp.Business.Utilities;
using FishingApp.Business.Utilities.AutoMapperProfiles;
using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.Repositories.Concrete;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using FishingApp.DataAccess.UnitOfWorks.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Extensions
{
    public static class BusinessLayerExtension
    {
        public static void LoadBusinessLayerExtension(this IServiceCollection serviceCollection)
        {
            //var ass = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(typeof(AutoMapperProfiles));
            serviceCollection.AddScoped<IBirimService, BirimService>();

        }
    }
}
