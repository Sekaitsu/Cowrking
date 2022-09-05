using AutoMapper;
using credinet.comun.api;
using Microsoft.Extensions.DependencyInjection;
using Domain.UseCase;
using DrivenAdapters.Mongo;
using Domain.Model.Entities.Gateway;
using Microsoft.Extensions.Logging;
using Domain.Model.Interfaces;
using Domain.UseCase.Common;

namespace CoworkingBack.AppServices
{
    /// <summary>
    /// ConfigurationServices
    /// </summary>
    public static class ConfigurationServices
    {
        /// <summary>
        /// AgregarServicios
        /// </summary>
        /// <param name="services"></param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AgregarServicios(this IServiceCollection services)
        {
            //service for type 'credinet.comun.api.RespuestaApiFactory'
            services.AddSingleton<IMensajesHelper, MensajesApiHelper>();

            services.AddScoped<IRegistroModalidadFormUserCase,ManageTestEntityUserCase>();

            services.AddScoped<ITestEntityRepository,EntityAdapter>();
            //provider => new EntityAdapter(services.BuildServiceProvider().GetRequiredService<IMapper>())
            //REGISTRE ACÁ SUS SERVICIOS

            services.AddSingleton<IManageEventsUseCase, ManageEventsUseCase>();

            return services;
        }
    }
}
