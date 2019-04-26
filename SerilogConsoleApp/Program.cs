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
               //.WriteTo.Console()
               .WriteTo.ColoredConsole()

               .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)  // 

               .WriteTo.File("log/Xog.txt", retainedFileCountLimit: 4, rollingInterval: RollingInterval.Minute)

               .WriteTo.File("log/Yog.txt", fileSizeLimitBytes: 1024, retainedFileCountLimit: 5, rollOnFileSizeLimit: true)

               .WriteTo.SQLite("db/test.db", tableName: "dataLog" )




               .CreateLogger();



            for (int i = 0; i < 100; i++)
            {
                log.Information($"Hello, Serilog! {i}");
            }


            Console.WriteLine();
            Console.WriteLine();

            log.Error("this is error");
            log.Information("this is info");
            log.Warning("this is warning");
            log.Fatal("this is fatal");

            log.Debug("this is debug");
            log.Verbose("this is verbose");
            


            Console.ReadKey();

        }
    }
}
