using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("priorities")]
    public class Priority
    {
        [Column("priority_id")]
        public int Id { get; set; }
        [Column("priority_name")]
        public string PriorityName { get; set; }
        [Column("priority_color")]
        public string PriorityColor { get; set; }
    }
}