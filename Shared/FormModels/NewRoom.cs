using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMatch_Blazor.Shared.FormModels
{
    public class NewRoom
    {
        [Required(ErrorMessage = "Please specify a username")]
        [StringLength(15, MinimumLength = 4)]
        public string Username { get; set; }
    }
}
