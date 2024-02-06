using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;


namespace SerilogCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //var log = new LoggerConfiguration()
            //  .WriteTo.Console(outputTemplate: " {Timestamp:HH:mm:ss} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}")
            //  .MinimumLevel.Verbose()
            //  .WriteTo.File("log/RollingDaylog.txt", rollingInterval: RollingInterval.Day)  //
            //  .WriteTo.File("log/RollingMinuteLog.txt", retainedFileCountLimit: 4, rollingInterval: RollingInterval.Minute)
            //  .WriteTo.File("log/Size-NumberLimitLog.txt", fileSizeLimitBytes: 1024, retainedFileCountLimit: 10, rollOnFileSizeLimit: true)
            //  //.WriteTo.SQLite("db/test.db", tableName: "dataLog")
            //  .CreateLogger();


            Console.WriteLine(  Directory.GetCurrentDirectory());


            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();



            var log = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();





            for (int i = 0; i < 199; i++)
            {


            WriteLogStuff(log, i);

            }



            Console.ReadKey();

        }




    public static void WriteLogStuff(ILogger log, int x)
        {
            Thread.Sleep(new Random().Next(100, 7000));

            string? proc = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            string? userId = Environment.GetEnvironmentVariable("USERNAME");
            string? ComputerName = Environment.GetEnvironmentVariable("COMPUTERNAME");

            log.Debug($"===== Loop #: {x}");
            log.Debug($"     User ID: {userId}");
            log.Debug($"         CPU: {proc}");
            log.Debug($"    Computer: {ComputerName}");
            log.Fatal("this is fatal");             // Highest
            log.Error("this is error");
            log.Warning("this is warning");
            log.Information("this is info");
            log.Debug("this is debug");
            log.Verbose("this is verbose");         // Lowest


        }

    }
}
