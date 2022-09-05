using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using credinet.comun.api;
using Domain.UseCase;
using Domain.Model.Entities;
using static credinet.comun.negocio.RespuestaNegocio<credinet.exception.middleware.models.ResponseEntity>;
using static credinet.exception.middleware.models.ResponseEntity;
using System;
using Microsoft.Extensions.Logging;
using EntryPoints.ReactiveWeb.Base;
using Domain.Model.Interfaces;

namespace EntryPoints.ReactiveWeb.Controllers
{
    /// <summary>
    /// EntityController
    /// </summary>
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/[controller]/[action]")]
    public class EntityController : AppBaseController <EntityController>
    {
        private readonly IRegistroModalidadFormUserCase testNegocio;
        private readonly IManageEventsUseCase eventsUseCase;


        /// <summary>
        /// EntityController
        /// </summary>
        /// <param name="testNegocio"></param>
        /// <param name="eventsUseCase"></param>
        public EntityController(IRegistroModalidadFormUserCase testNegocio, IManageEventsUseCase eventsUseCase) : base(eventsUseCase)
        {
            
            this.testNegocio = testNegocio;
            this.eventsUseCase = eventsUseCase;
        }

        /// <summary>
        /// Obtiene todos los objetos de tipo <see cref="Entity"/>
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Retorna la lista</response>
        /// <response code="400">Si existe algun problema al consultar</response>
        /// <response code="406">Si no se envia el ambiente correcto</response>
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(406)]
        [HttpGet()]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Entity>))]
        public async Task<IActionResult> Get()
        {
           
            return await ResolverSolicitud(async () =>  await testNegocio.GetAllUsers(), Guid.NewGuid().ToString()); // ejecutar el resolver solicitud
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost()]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Entity>))]
        public async Task<IActionResult> Create([FromBody] Entity entity)
        {
            var respuestaNegocio = await testNegocio.GetAllUsers(entity);
            return await ProcesarResultado(Exito(Build(Request.Path.Value, 0, "", "co", respuestaNegocio)));
        }

    }
}