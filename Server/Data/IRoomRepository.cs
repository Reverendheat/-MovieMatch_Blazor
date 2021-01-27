using MovieMatch_Blazor.Shared.Services;
using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Server.Data
{
    public interface IRoomRepository
    {
        Task<ServiceResponse<IAppState>> CreateRoom(IAppState state);
        Task<ServiceResponse<IAppState>> JoinRoom(IAppState state);
/*        Task<ServiceResponse<IAppState>> RegisterUser(IAppState state);*/
    }
}
