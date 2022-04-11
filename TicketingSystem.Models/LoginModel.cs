using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class LoginModel
    {
        [Display(Name = "Username", Prompt = "Unesite username...")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Polje passowrd je obavezno")]
        [Display(Name = "Password polje", Prompt = "Unesite password...")]
        public string Password { get; set; }
    }
}
