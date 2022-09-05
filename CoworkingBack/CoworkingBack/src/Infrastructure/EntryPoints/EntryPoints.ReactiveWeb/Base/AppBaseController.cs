using credinet.comun.api;
using credinet.exception.middleware.models;
using Domain.Model.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Helpers.ObjectsUtils.ResponseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static credinet.comun.negocio.RespuestaNegocio<credinet.exception.middleware.models.ResponseEntity>;
using static credinet.exception.middleware.models.ResponseEntity;
using Helpers.Commons.Exceptions;
using Helpers.ObjectsUtils;

namespace EntryPoints.ReactiveWeb.Base
{
    /// <summary>
    /// AppBaseController
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AppBaseController<T> : BaseController<T>
    {
        private readonly string country = "Co";

        private readonly IManageEventsUseCase _eventsUseCase;

        /// <summary>
        /// <see cref="AppBaseController{T}"/>
        /// </summary>
        /// <param name="eventsUseCase"></param>
        public AppBaseController(IManageEventsUseCase eventsUseCase)
        {
            _eventsUseCase = eventsUseCase;
        }

        /// <summary>
        /// <see cref="ResolverSolicitud{T}(Func{Task{T}}, string)"/>
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="resolverSolicitud"></param>
        /// <param name="logid"></param>
        /// <returns></returns>
        public async Task<IActionResult> ResolverSolicitud<TResult>(Func<Task<TResult>> resolverSolicitud, string logid)
        {
            string actionName = ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = ControllerContext.RouteData.Values["Controller"].ToString();
            string eventName = $"{controllerName}.{actionName}";

            _eventsUseCase.ConsoleProcessLog(eventName, logid, data: null);

            try
            {
                TResult result = await resolverSolicitud();
                return await ProcesarResultado(Exito(Build(Request.Path.Value, 0, "", country, result)));
            }
            catch (BusinessException)
            {

                throw;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.StackTrace);
                return BadRequest(new ResponseError(new List<ResponseContent> {
                    new ResponseContent(ex.Message, 
                    $"{(TipoExcepcionNegocio.ExceptionNoControlada.GetDescription(), (int)TipoExcepcionNegocio.ExceptionNoControlada)}  {ex.Message}") }));
            }

        } 
    }
}
