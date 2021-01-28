using Microsoft.AspNetCore.SignalR.Client;
using MovieMatch_Blazor.Shared;
using MovieMatch_Blazor.Shared.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Shared.Services
{
    public interface IAppState
    {
        List<string> Users { get; set; }
        string RoomCode { get; set; }
        string Username { get; set; }
        string UserCode { get; set; }
        string Text { get; set; }
        bool RoomIsValid { get; set; }
        bool UserIsAdmin { get; set; }
        bool ShowStarted { get; set; }
        bool Loading { get; set; }
        HubConnection hubConnection { get; set; }
        List<Message> Messages { get; set; }
    }
}
