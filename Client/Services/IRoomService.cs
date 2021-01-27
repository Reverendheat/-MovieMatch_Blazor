using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Client.Services
{
    public interface IRoomService
    {
        Task<ServiceResponse<Room>> CreateRoom(User user);
        Task<ServiceResponse<Room>> JoinRoom(IAppState state);
    }
}
