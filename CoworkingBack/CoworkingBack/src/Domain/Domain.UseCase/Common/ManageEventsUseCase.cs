using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Interfaces;

namespace Domain.UseCase.Common
{
    /// <summary>
    /// ManageEventsUseCase
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ManageEventsUseCase : IManageEventsUseCase
    {
        private readonly ILogger<ManageEventsUseCase> _logger;
        /// <summary>
        /// ManageEventsUseCase
        /// </summary>
        /// <param name="logger"></param>
        public ManageEventsUseCase(ILogger<ManageEventsUseCase> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// <see cref="ConsoleProcessLog(string, string, dynamic, bool, string)"/>
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="writeData"></param>
        /// <param name="callerMemberName"></param>
        public void ConsoleProcessLog(string eventName, string id, dynamic data, bool writeData = false, [CallerMemberName] string callerMemberName = null)
        {
            _logger.LogInformation($"ClassName: {eventName}  MethodName: {callerMemberName}  Id: {id}");
            if (writeData)
                _logger.LogInformation($"Data: {data}");
        }
    }
}
