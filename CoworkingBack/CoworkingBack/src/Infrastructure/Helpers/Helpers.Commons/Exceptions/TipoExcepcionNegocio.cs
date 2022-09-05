using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Commons.Exceptions
{
    /// <summary>
    /// TipoExcepcionNegocio
    /// </summary>
    public enum TipoExcepcionNegocio
    {
        /// <summary>
        /// ExceptionNoControlada
        /// </summary>
        [Description("Exepcion No Controlada")]
        ExceptionNoControlada = 555,

        /// <summary>
        /// ErrorAlConectarConElServidor
        /// </summary>
        [Description("Problemas Al Conectarse Con El Servidor")]
        ErrorAlConectarConElServidor = 500,

        


    }
}
