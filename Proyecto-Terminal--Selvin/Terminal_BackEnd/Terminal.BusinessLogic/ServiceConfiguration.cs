using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Terminal.BusinessLogic.Services;
using Terminal.DataAccess;
using Terminal.DataAccess.Repository;

namespace Terminal.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string connectionString)
        {
            service.AddScoped<ClientesRepository>();
            service.AddScoped<CargosRepository>();
            service.AddScoped<TerminalesRepository>();
            service.AddScoped<HorariosRepository>();
            service.AddScoped<BoletosRepository>();
            service.AddScoped<CompañiaRepository>();
            service.AddScoped<EmpleadoRepository>();

            TerminalContext.BuildConnectionString(connectionString);
        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<TerminalService>();
        }
    }
}
