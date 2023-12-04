using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace deepcheesebacon.Hubs
{
    public class ChatHub
    {
        public async Task SendMessage(string user, string message)
        {
            //await Clients.All.SendAsync("Receive Message", user, message);

        }
    }
}
