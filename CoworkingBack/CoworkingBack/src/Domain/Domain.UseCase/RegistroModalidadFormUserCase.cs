using Domain.Model.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.UseCase
{
    /// <summary>
    /// RegistroModalidadFormUserCase
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    //a donde quiero llegar no como
    public class RegistroModalidadFormUserCase : ControllerBase, IRegistroModalidadFormUserCase
    {
        /// <summary>
        /// RegistroModalidadFormUserCase
        /// </summary>
        public RegistroModalidadFormUserCase()
        {      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recoModFormRequest"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ActionResult<RecoModFormRequest>> ValidarFormulario(RecoModFormRequest recoModFormRequest)
        {
            try
            {
                bool validacionEmail = ValidarEmailUsuarioAsync(recoModFormRequest.Correo);
                if (!recoModFormRequest.DisponibilidadPc)
                    return BadRequest("Solicitar al lider que se le asigne un equipo para completar el proceso de enrolamiento");


                //{
                    
                //}
                //else
                //{
                //    if (!recoModFormRequest.TipoModalidad)
                //    {
                //        if (!recoModFormRequest.ProdEnCasa || recoModFormRequest.ProdEnCasa)
                //        {
                //            if (!recoModFormRequest.ConexionCasa || recoModFormRequest.ConexionCasa)
                //            {
                //                if(!recoModFormRequest.ReqConexionVpn || recoModFormRequest.ReqConexionVpn)
                //                {
                //                    if(!recoModFormRequest.DispoTrabajoPcPersonal || recoModFormRequest.DispoTrabajoPcPersonal)
                //                    {
                                        
                //                    }
                //                }

                //            }
                //        }
                //    }
                //    else
                //    {
                //        return Ok();
                //    }
                //}
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
            
        }

        public class ValidarFormulario : AbstractValidator<RecoModFormRequest>
        {
            public ValidarFormulario()
            {

                RuleFor(x => x.DisponibilidadPc).NotNull();
                RuleFor(x => x.TipoModalidad)
            }
        }




    }
}
