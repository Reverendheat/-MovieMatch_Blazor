using MovieMatch_Blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Client.Services
{
    public interface IAppState
    {
        Room room { get; set; }
        User user { get; set; }
        bool roomIsValid { get; set; }
    }
}
