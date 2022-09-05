using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.ObjectsUtils.ResponseObjects
{
    /// <summary>
    /// ResponseError
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ResponseError
    {
        /// <summary>
        /// ResponseError
        /// </summary>
        public List<ResponseContent> _errors { get; set; }

        /// <summary>
        /// ResponseError
        /// </summary>
        public ResponseError()
        {

        }

        /// <summary>
        /// ResponseError
        /// </summary>
        /// <param name="errors"></param>
        public ResponseError(List<ResponseContent> errors)
        {
            _errors = errors;
        }

        
    }
    /// <summary>
    /// ResponseContent
    /// </summary>

    [ExcludeFromCodeCoverage]
    public class ResponseContent
    {
        /// <summary>
        /// ResponseContent
        /// </summary>
        public string _message { get; set; }

        /// <summary>
        /// ResponseContent
        /// </summary>
        public string _code { get; set; }

        /// <summary>
        /// ResponseContent
        /// </summary>
        public ResponseContent()
        {

        }

        /// <summary>
        /// ResponseContent
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        public ResponseContent(string msg, string code)
        {
            _message = msg; 
            _code = code;   
        }

        
    }
}
