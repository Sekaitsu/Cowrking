using Helpers.Commons.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model.Entities
{
    /// <summary>
    /// Entidad de solicitud Formulario 
    /// </summary>
    public class RecoModFormRequest 
    {
        /// <summary>
        /// Correo
        /// </summary>
        [Required]
        [EmailAddress]
        [ValidacionCorreo(TipoDato.correo)]
        public string Correo { get; set; }
        /// <summary>
        /// DisponibilidadPc
        /// </summary>
        [Required]
        public bool DisponibilidadPc { get; set; }
        /// <summary>
        /// TipoModalidad
        /// </summary>
        [Required]
        public TipoModalidad TipoModalidad { get; set; }
        /// <summary>
        /// ProdEnCasa
        /// </summary>
        [Required]
        public bool ProdEnCasa { get; set; }
        /// <summary>
        /// ConexionCasa
        /// </summary>
        [Required]
        public bool ConexionCasa { get; set; }
        /// <summary>
        /// ReqConexionVpn
        /// </summary>
        [Required]
        public bool ReqConexionVpn { get; set; }
        /// <summary>
        /// PcPersonal
        /// </summary>
        [Required]
        public bool PcPersonal { get; set; }
        /// <summary>
        /// DispoTrabajoPcPersonal
        /// </summary>
        [Required]
        public bool DispoTrabajoPcPersonal { get; set; }
    }
}
