using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Shared
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomCode { get; set; }
        public List<User> Users { get; set; }
    }
}
