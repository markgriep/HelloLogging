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

               .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)  // 

               .WriteTo.File("log/Xog.txt", retainedFileCountLimit: 4, rollingInterval: RollingInterval.Minute)

               .WriteTo.File("log/Yog.txt", fileSizeLimitBytes: 1024, retainedFileCountLimit: 5, rollOnFileSizeLimit: true)

               .WriteTo.SQLite("db/test.db", tableName: "dataLog" )



               .CreateLogger();



            for (int i = 0; i < 100; i++)
            {
                log.Information($"Hello, Serilog! {i}");
            }



            Console.ReadKey();

        }
    }
}
