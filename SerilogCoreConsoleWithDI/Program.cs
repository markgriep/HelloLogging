using Microsoft.Extensions.DependencyInjection;


namespace SerilogCoreConsoleWithDI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            //var genericService = serviceProvider.GetService<IService>();
            var messagingService = serviceProvider.GetService<IMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1,357));
            var messagingService1 = serviceProvider.GetService<IMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            var messagingService2 = serviceProvider.GetService<IMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            var messagingService3 = serviceProvider.GetService<IMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));



            var messagingServiceTransient = serviceProvider.GetService<ITransientMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            var messagingServiceTransient1 = serviceProvider.GetService<ITransientMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            var messagingServiceTransient2 = serviceProvider.GetService<ITransientMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));
            var messagingServiceTransient3 = serviceProvider.GetService<ITransientMessagingService>();
            System.Threading.Thread.Sleep(new Random().Next(1, 357));







            messagingService.SendMessage("Hello MOM SINGLETON", "612-724-7574");
            messagingService1.SendMessage("Hello BANK SINGLETON", "952-831-6600");
            messagingService2.SendMessage("Hello SLP SINGLETON", "952-926-4052");
            messagingService3.SendMessage("Hello OLDHOUSE SINGLETON", "612-724-8910");

            Console.WriteLine("");

            messagingServiceTransient.SendMessage("Hello MOM TRANSIENT", "612-724-7574");
            messagingServiceTransient1.SendMessage("Hello BANK TRANSIENT", "952-831-6600");
            messagingServiceTransient2.SendMessage("Hello SLP TRANSIENT", "952-926-4052");
            messagingServiceTransient3.SendMessage("Hello OLDHOUSE TRANSIENT", "612-724-8910");



            var x = serviceCollection.Count();
            Console.WriteLine(  x);

        }


        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IService, Service>();
            serviceCollection.AddSingleton<IMessagingService, MessagingService>();
            serviceCollection.AddTransient<ITransientMessagingService, MessagingService>();
        }

    }


}
