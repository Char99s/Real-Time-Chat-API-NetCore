using Microsoft.AspNetCore.SignalR;

namespace SignalRAPI
{
    public sealed class ChatHub : Hub<IChatClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId} has joined");
        }

        public async Task sendMessage(string Message)
        {
            await Clients.All.ReceiveMessage($"{Context.ConnectionId}: {Message}");
        }
    }
}
