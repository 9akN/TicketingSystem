using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("employees")]
    public class Login : IdentityUser
    {
        [Column("username")]
        public string? Username { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}
