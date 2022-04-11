using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("statuses")]
    public class Status
    {
        [Column("status_id")]
        public int Id { get; set; }
        [Column("status_name")]
        public string StatusName { get; set; }
        [Column("status_color")]
        public string StatusColor { get; set; }
    }
}
