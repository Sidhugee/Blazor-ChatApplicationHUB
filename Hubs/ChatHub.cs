using Microsoft.AspNetCore.SignalR;

namespace BlazorChatSignalR.Server.Hubs
{
    // SignalR Hub is basicaaly used for maintaining the connection btw the server and clients. 
    public class ChatHub: Hub
    {
       
// This function is basically main hub that initialize the communicating way btw been server and clients
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage" , user, message); 
        }
    }
}
