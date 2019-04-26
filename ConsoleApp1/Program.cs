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
            log.Error("this is an minor error");
            log.Warn("this is a warn");
            log.Debug("this is a minor debug");
            log.Info("this is info");
            log.Fatal("this is fatal");
            log.Fatal("this is fatal you couldn't say it was minor");
            //log.Debug($"log a message {i}", new DivideByZeroException {  });                    //passing an exception as the second parameter
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
