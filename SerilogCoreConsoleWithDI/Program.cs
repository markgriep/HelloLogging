using Microsoft.Extensions.DependencyInjection;


namespace SerilogCoreConsoleWithDI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ExperimentWithServices();

        }

        private static void ExperimentWithServices()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();


            var messagingService = serviceProvider.GetService<IMessagingService>();
            var messagingService1 = serviceProvider.GetService<IMessagingService>();
            var messagingService2 = serviceProvider.GetService<IMessagingService>();
            var messagingService3 = serviceProvider.GetService<IMessagingService>();



            var messagingServiceTransient = serviceProvider.GetService<ITransientMessagingService>();
            var messagingServiceTransient1 = serviceProvider.GetService<ITransientMessagingService>();
            var messagingServiceTransient2 = serviceProvider.GetService<ITransientMessagingService>();
            var messagingServiceTransient3 = serviceProvider.GetService<ITransientMessagingService>();



            messagingService.SendMessage("Hello MOM SINGLETON", "612-724-7574");
            messagingService1.SendMessage("Hello BANK SINGLETON", "952-831-6600");
            messagingService2.SendMessage("Hello SLP SINGLETON", "952-926-4052");
            messagingService3.SendMessage("Hello OLDHOUSE SINGLETON", "612-724-8910");



            messagingServiceTransient.SendMessage("Hello MOM TRANSIENT", "612-724-7574");
            messagingServiceTransient1.SendMessage("Hello BANK TRANSIENT", "952-831-6600");
            messagingServiceTransient2.SendMessage("Hello SLP TRANSIENT", "952-926-4052");
            messagingServiceTransient3.SendMessage("Hello OLDHOUSE TRANSIENT", "612-724-8910");



            var serviceCount = serviceCollection.Count();
            Console.WriteLine($"Number of Services registered:{serviceCount}");
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IService, Service>();
            serviceCollection.AddSingleton<IMessagingService, MessagingService>();
            serviceCollection.AddTransient<ITransientMessagingService, MessagingService>();
        }

    }


}
