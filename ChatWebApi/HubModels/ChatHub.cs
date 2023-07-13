using ChatWebApi.Models;
using Microsoft.AspNetCore.SignalR;
namespace ChatWebApi.HubModels
{
    public class ChatHub:Hub
    {
        public async Task GetMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
            
        }
    }
}
