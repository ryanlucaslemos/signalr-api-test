using Microsoft.AspNetCore.SignalR;

using System;
using System.Threading.Tasks;

namespace signalRApi.Hubs
{
    public class MessageHub : Hub
    {
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }

    public class Message
    {
        public string username { get; set; }
        public string clientuniqueid { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}
