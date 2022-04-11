using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("employees")]
    public class Employee
    {
        [Column("employee_id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("username")]
        public string? Username { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("ssh_key")]
        public string? SshKey { get; set; }
    }
}
