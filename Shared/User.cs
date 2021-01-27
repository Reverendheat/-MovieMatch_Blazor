using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Shared
{
    public class User
    {
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string Username { get; set; }
        public string UserCode { get; set; }
    }
}
