using ChatApp.WebAPI.Hubs.Clients;
using ChatApp.WebAPI.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatApp.WebAPI.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
