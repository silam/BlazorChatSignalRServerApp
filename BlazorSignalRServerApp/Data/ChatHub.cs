using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRServerApp.Data
{
    public class ChatHub: Hub
    {
        public ChatHub() { }

        public async Task SendMessage(string sender, string receiver, string msgTitle, string msgBody)
        {
            await Clients.All.SendAsync("ReceiveMessage", sender, receiver, msgTitle, msgBody);
        }
    }
}
