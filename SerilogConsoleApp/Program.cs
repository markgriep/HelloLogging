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
             
               .WriteTo.ColoredConsole(outputTemplate: " {Timestamp:HH:mm} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}")
               .MinimumLevel.Verbose()
               
               .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)  // 

               .WriteTo.File("log/Xog.txt", retainedFileCountLimit: 4, rollingInterval: RollingInterval.Minute)

               .WriteTo.File("log/Yog.txt", fileSizeLimitBytes: 1024, retainedFileCountLimit: 5, rollOnFileSizeLimit: true)

               .WriteTo.SQLite("db/test.db", tableName: "dataLog" )

               .CreateLogger();


            
            log.Fatal("this is fatal");             // Highest
            log.Error("this is error");
            log.Warning("this is warning");
            log.Information("this is info");
            log.Debug("this is debug");
            log.Verbose("this is verbose");         // Lowest
         

            Console.ReadKey();

        }
    }
}
