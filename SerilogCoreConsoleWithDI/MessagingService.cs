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



    public interface ITransientMessagingService
    {
        void SendMessage(string message, string address);
    }


    internal class MessagingService :IMessagingService, ITransientMessagingService
    {

        int pseudoId = 0;

        public MessagingService()
        {
            pseudoId = DateTime.Now.Millisecond;

            Console.WriteLine($"MessagingService instance created. the pseudo-id is {pseudoId}");
        }

        public void SendMessage(string message, string address)
        {
            Console.WriteLine($"Message sent to {address} with message {message}  Instance ID: {pseudoId}");
        }
    }

}
