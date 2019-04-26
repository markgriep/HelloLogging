using Serilog;
using System;

namespace SerilConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)
                .MinimumLevel.Verbose()
                .CreateLogger();

            var userId = "mgasrs";

            log.Fatal("this is fatal");             // Highest
            log.Error("this is error");
            log.Warning("this is warning");
            log.Information("this is info");
            log.Debug($"debug from : {userId}");
            log.Verbose("this is verbose");         // Lowest


            Console.ReadKey();

        }
    }
}
