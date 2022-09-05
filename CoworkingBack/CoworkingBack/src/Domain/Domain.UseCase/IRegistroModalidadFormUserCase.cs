using Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Domain.UseCase
{
    /// <summary>
    /// IManageTestEntityUserCase
    /// </summary>
    public interface IRegistroModalidadFormUserCase
    {
        /// <summary>
        /// <see cref="ValidarFormuario(RecoModFormRequest)"/>
        /// </summary>
        /// <param name="recoModFormRequest"></param>
        /// <returns></returns>
        Task<ActionResult<RecoModFormRequest>> ValidarFormulario(RecoModFormRequest recoModFormRequest);

        ///// <summary>
        ///// <see cref="FindAll(Entity)"/>
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //List<Entity> FindAll(Entity entity = null);

        ///// <summary>
        ///// <see cref="GetAllUsers(Entity)"/>
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //Task<IList<Entity>> GetAllUsers(Entity entity = null);
    }
}