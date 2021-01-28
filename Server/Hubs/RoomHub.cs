using Microsoft.AspNetCore.SignalR;
using MovieMatch_Blazor.Shared.Services;
using MovieMatch_Blazor.Server.Data;
using System.Threading.Tasks;
using MovieMatch_Blazor.Shared.FormModels;

namespace MovieMatch_Blazor.Server.Hubs
{
    public class RoomHub : Hub
    {
        private IRoomRepository _roomRepository;
        public RoomHub(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task Register(string roomCode, string username)
        {
            //Update the AppState with all of the users that currently exist
            await Groups.AddToGroupAsync(Context.ConnectionId, roomCode);
            await Clients.Group(roomCode).SendAsync("NewUser", username);
        }

        public async Task SendMessage(string username, string roomCode, string message)
        {
            var newMessage = new Message()
            {
                Username = username,
                Text = message
            };
            await Clients.Group(roomCode).SendAsync("ReceiveMessage", newMessage);
        }
    }
}
