using GeoCode.BL;
using GeoCode.DAL;
using GeoCode.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoCode.Web.API
{
    public class DependencyInjectionConfig
    {
        public static void AddScope(IServiceCollection services)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
        }
    }
}
