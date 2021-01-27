using Microsoft.AspNetCore.SignalR;
using MovieMatch_Blazor.Client.Services;
using MovieMatch_Blazor.Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Server.Hubs
{
    public class RoomHub : Hub
    {
        private IRoomRepository _roomRepository;
        public RoomHub(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task Register(AppState state)
        {
            //Update the AppState with all of the users that currently exist
            await Groups.AddToGroupAsync(Context.ConnectionId, state.room.RoomCode);
            if(state.room.Users.Any(u=>u.UserCode != state.user.UserCode))
            {
                //var roomUpdate = await _roomRepository.RegisterUser(state);
                await Clients.Group(state.room.RoomCode).SendAsync("NewUser", $"Hey {Context.ConnectionId}");
            }
        }
    }
}
