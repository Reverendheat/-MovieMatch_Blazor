using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Client.Services
{
    public class AppState : IAppState
    {
        public Room room { get; set; }
        public User user { get; set; }
        public bool roomIsValid { get; set; }
    }
}
