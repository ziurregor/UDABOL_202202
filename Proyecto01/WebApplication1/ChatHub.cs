using Microsoft.AspNetCore.SignalR;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System;

namespace WebApplication1.Signalr.hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
           // Clients.All.addNewMessageToPage(name, message);

        }
    }
}
