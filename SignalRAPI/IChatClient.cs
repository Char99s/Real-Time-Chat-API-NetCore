namespace SignalRAPI
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
