using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogCoreConsoleWithDI
{
    public interface IMessagingService
    {
        void SendMessage(string message, string address);
    }
}
