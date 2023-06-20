using Microsoft.AspNetCore.SignalR;

namespace SignalRProject.Hubs
{
    public class TASSignalRHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
