using Microsoft.AspNetCore.SignalR.Client;
using MovieMatch_Blazor.Shared;
using MovieMatch_Blazor.Shared.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Shared.Services
{
    public class AppState : IAppState
    {
        public List<string> Users { get; set; } = new List<string>();
        public string RoomCode { get; set; }
        public string UserCode { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }
        public bool RoomIsValid { get; set; } = false;
        public bool UserIsAdmin { get; set; } = false;
        public bool ShowStarted { get; set; } = false;
        public bool Loading { get; set; } = false;
        public HubConnection hubConnection { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
