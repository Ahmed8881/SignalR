using Microsoft.AspNetCore.SignalR;
namespace SignalR.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("RecieveMessage",user,message);

        }
    }
}
