using Microsoft.Extensions.DependencyInjection;
using PruebaApi.BusinessLogic.Services;
using PruebaApi.DataAccess;
using PruebaApi.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaApi.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string connectionString)
        {
            service.AddScoped<tbClientesRepository>();
       
            TerminalContext.BuildConnectionString(connectionString);
        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<TermService>();

        }
    }
}
