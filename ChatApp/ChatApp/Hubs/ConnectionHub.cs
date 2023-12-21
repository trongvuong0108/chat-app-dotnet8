
using ChatApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Hubs
{
    public sealed class ConnectionHub : Hub
    { 
        public override async Task OnConnectedAsync() => await Clients.All.SendAsync("ReceiveMessage", "Hello bitch");
        public override async Task OnDisconnectedAsync(Exception? exception) => await Clients.All.SendAsync("ReceiveMessage", $"Bye bitch: {exception.Message}");
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
    public class ChatMessage
    {
        public string Message { get; set; }
    }
}
