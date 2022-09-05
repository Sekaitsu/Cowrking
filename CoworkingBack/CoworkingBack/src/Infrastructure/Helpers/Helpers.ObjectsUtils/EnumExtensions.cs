using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.ObjectsUtils
{
    /// <summary>
    /// EnumExtensions
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class EnumExtensions
    {
        /// <summary>
        /// GetDescription
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumeracion"></param>
        /// <returns></returns>
        public static string GetDescription<T>(this T enumeracion) where T : IConvertible
        {
            if (enumeracion is Enum)
            {
                Type type = enumeracion.GetType();
                Array array = Enum.GetValues(type);

                foreach (int item in array)
                {
                    if (item == enumeracion.ToInt32(CultureInfo.InvariantCulture))
                    {
                        System.Reflection.MemberInfo[] respuesta = type.GetMember(type.GetEnumName(item));

                        if (respuesta[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                        {
                            return descriptionAttribute.Description;
                        }
                    }

                    
                }
            }

            return string.Empty;    
        }
    }
}
