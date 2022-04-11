using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("roles")]
    public class Role
    {
        [Column("role_id")]
        public int Id { get; set; }
        [Column("role_name")]
        public string RoleName { get; set; }
    }
}
