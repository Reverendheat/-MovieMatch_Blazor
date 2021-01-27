using MovieMatch_Blazor.Shared;
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
        bool roomIsValid { get; set; }
    }
}
