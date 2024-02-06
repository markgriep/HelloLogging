using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Sinks.SystemConsole.Themes;


namespace SerilogCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var log = new LoggerConfiguration()
            //  .WriteTo.Console(theme: AnsiConsoleTheme.Code, outputTemplate: " {Timestamp:HH:mm:ss} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}")
            //  .MinimumLevel.Verbose()
            //  .WriteTo.File("log/RollingDaylog.txt", rollingInterval: RollingInterval.Day)  //
            //  .WriteTo.File("log/RollingMinuteLog.txt", retainedFileCountLimit: 4, rollingInterval: RollingInterval.Minute)
            //  .WriteTo.File("log/Size-NumberLimitLog.txt", fileSizeLimitBytes: 1024, retainedFileCountLimit: 10, rollOnFileSizeLimit: true)
            //  //.WriteTo.SQLite("db/test.db", tableName: "dataLog")
            //  .CreateLogger();



            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();

            var log = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .WriteTo.Console(theme: AnsiConsoleTheme.Sixteen)       // This is for using themes.  Can't put in Configuration file
                .CreateLogger();

            for (int i = 0; i < 199; i++)
            {
                WriteLogStuff(log, i);
            }

            Console.ReadKey();
        }




    public static void WriteLogStuff(ILogger log, int x)
        {
            Thread.Sleep(GetBellRandom(100, 700, 500));

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

    public static int GetBellRandom(int min, int max, int mean)
    {
            double stdDev = (max - min) / 6.0; // Assuming a standard deviation where ~99.7% of values fall within min and max
            Random rand = new Random();
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
            return Math.Max(min, Math.Min(max, (int)Math.Round(randNormal))); // Clipping to min and max
    }







}
}
