using MovieMatch_Blazor.Shared;
using MovieMatch_Blazor.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Client.Services
{
    public interface IRoomService
    {
        Task<ServiceResponse<AppState>> CreateRoom(IAppState state);
        Task<ServiceResponse<AppState>> JoinRoom(IAppState state);
    }
}
