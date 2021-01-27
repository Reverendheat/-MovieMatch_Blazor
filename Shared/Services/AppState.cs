using MovieMatch_Blazor.Shared;
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
        public bool roomIsValid { get; set; } = false;
    }
}
