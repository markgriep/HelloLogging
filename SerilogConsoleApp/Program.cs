using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
               .WriteTo.Console()
               .CreateLogger();

            log.Information("Hello, Serilog!");


            Console.ReadKey();

        }
    }
}
