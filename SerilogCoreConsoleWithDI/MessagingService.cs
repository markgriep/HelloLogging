using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogCoreConsoleWithDI
{



    internal class MessagingService :IMessagingService, ITransientMessagingService
    {

        int pseudoId = 0;

        public MessagingService()
        {
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            pseudoId = DateTime.Now.Millisecond;

            Console.WriteLine($"MessagingService instance created. the pseudo-id is {pseudoId}");
        }

        public void SendMessage(string message, string address)
        {
            Console.WriteLine($"Message sent to {address} with message {message}  Instance ID: {pseudoId}");
        }
    }

}
