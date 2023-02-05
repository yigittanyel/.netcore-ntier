using FishingApp.Business.Services.Abstract;
using FishingApp.Business.Services.Concrete;
using FishingApp.Business.Utilities;
using FishingApp.Business.Utilities.AutoMapperProfiles;
using FishingApp.DataAccess.Context;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.Repositories.Concrete;
using FishingApp.DataAccess.UnitOfWorks.Abstract;
using FishingApp.DataAccess.UnitOfWorks.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
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
        public static void LoadBusinessLayerExtension(this IServiceCollection serviceCollection, IConfiguration config)
        {
            //var ass = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(typeof(AutoMapperProfiles));

            serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(config.GetSection("AppSettings:Token").Value)),
                   ValidateIssuer = false,
                   ValidateAudience = false
               };
           });

            serviceCollection.AddScoped<IBirimService, BirimService>();
            serviceCollection.AddScoped<IKullaniciService, KullaniciService>();

        }
    }
}
