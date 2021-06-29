using ChatApp.WebAPI.Models;
using System.Threading.Tasks;

namespace ChatApp.WebAPI.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
