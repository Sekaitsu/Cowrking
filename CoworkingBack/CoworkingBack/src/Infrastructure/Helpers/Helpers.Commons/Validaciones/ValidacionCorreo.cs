using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Commons.Validaciones
{
    /// <summary>
    /// ValidacionCorreo
    /// </summary>
    /// <seealso cref="ValidationAttribute"/>
    public class ValidacionCorreo : ValidationAttribute
    {
        private readonly string[] _correoValidos;



        /// <summary>
        /// ValidacionCorreo
        /// </summary>
        /// <param name="correoValidos"></param>
        public ValidacionCorreo(string[] correoValidos)
        {
            _correoValidos = correoValidos;
        }



        /// <summary>
        /// ValidacionCorreo
        /// </summary>
        /// <param name="tipoDato"></param>
        public ValidacionCorreo(TipoDato tipoDato)
        {
            if (tipoDato == TipoDato.correo)
            {
                _correoValidos = new string[] { "sistecredito.com", "lugopago.com", "sistetiendas.com", "sistepagos.com", "sistepass.com" };
            }
        }



        /// <summary>
        /// <see cref="IsValid(object, ValidationContext)"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }



            string convertidor = value.ToString();
            string[] dominio = convertidor.Split('@');



            if (!_correoValidos.Contains(dominio[1].ToString()))
            {
                return new ValidationResult($"El Tipo De Correo Debe De Ser Uno De Los Siguientes: {string.Join(", ", _correoValidos)}");
            }



            return ValidationResult.Success;



        }
    }
}
