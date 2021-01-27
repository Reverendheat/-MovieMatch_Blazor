using Microsoft.AspNetCore.SignalR;
using MovieMatch_Blazor.Shared.Services;
using MovieMatch_Blazor.Server.Data;
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
            await Groups.AddToGroupAsync(Context.ConnectionId, state.RoomCode);
            await Clients.Group(state.RoomCode).SendAsync("NewUser", state.Username);
        }
    }
}
