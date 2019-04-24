using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleApp1
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");

        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)          // loop a bunch to test the rolling log
            {
                log.Debug($"log a message {i}", new DivideByZeroException {  });                    //passing an exception as the second parameter
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
