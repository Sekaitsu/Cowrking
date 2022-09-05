using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Interfaces
{
    /// <summary>
    /// IManage Events UseCase
    /// </summary>
    public interface IManageEventsUseCase 
    {
        /// <summary>
        /// Console error log
        /// </summary>
        void ConsoleProcessLog(string eventName, string id, dynamic data, bool writeData = false, [CallerMemberName] string callerMemberName = null);
    }
}
