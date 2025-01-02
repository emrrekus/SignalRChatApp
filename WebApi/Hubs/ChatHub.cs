using System;
using Microsoft.AspNetCore.SignalR;

namespace WebApi.Hubs;

public sealed class ChatHub : Hub
{
    public Task SendMessageAsync(string user, string message)
    {
        return Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
