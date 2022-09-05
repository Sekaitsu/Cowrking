using System;
using AutoMapper;
using System.Collections.Generic;
using Domain.Model.Entities;
using Domain.Model.Entities.Gateway;
using Microsoft.Extensions.Logging;

namespace DrivenAdapters.Mongo
{
    /// <summary>
    /// EntityAdapter
    /// </summary>
    public class EntityAdapter : ITestEntityRepository
    {
        private readonly IMapper mapper;
        private readonly ILogger<EntityAdapter> _logger;

        public EntityAdapter(IMapper mapper)
        {
            this.mapper = mapper;
        }

        /// <summary>
        /// build
        /// </summary>
        /// <param name="mapper"></param>
        public EntityAdapter(IMapper mapper, ILogger<EntityAdapter> logger)
        {
            _logger = logger;
            this.mapper = mapper;
        }

        /// <summary>
        /// FindAll
        /// </summary>
        /// <returns>Entity list</returns>
        public List<Entity> FindAll(Entity entity = null)
        {
            _logger.LogInformation("Entro al adapter en: {time}", DateTimeOffset.Now);
            if (entity == null)
            {
                try
                {
                    /*var lista = new List<Entity>();
                                    var datoEntrega = new Entity { Id = Guid.NewGuid(), descrip = "Test" };
                                    lista.Add(datoEntrega);
                                    return lista;*/
                    return mapper.Map<List<Entity>>(new List<Entities.Entity> { new Entities.Entity { Id = Guid.NewGuid(), descrip = "Test" } });
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }
            return mapper.Map<List<Entity>>(new List<Entities.Entity> { new Entities.Entity { Id = entity.Id, descrip = entity.descrip } });
        }
    }
}