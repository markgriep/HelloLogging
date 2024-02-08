namespace SerilogCoreConsoleWithDI
{
    public interface ITransientMessagingService
    {
        void SendMessage(string message, string address);
    }
}