using MovieMatch_Blazor.Client.Services;
using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Server.Data
{
    public interface IRoomRepository
    {
        Task<ServiceResponse<Room>> CreateRoom(User user);
        Task<ServiceResponse<Room>> JoinRoom(IAppState state);
        Task<ServiceResponse<Room>> RegisterUser(IAppState state);
    }
}
