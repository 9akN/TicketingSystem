using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("comments")]
    public class Comment
    {
        [Column("comment_id")]
        public int Id { get; set; }
        [Column("the_content")]
        public string Content { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("ticket_id")]
        public int TicketId { get; set; }
    }
}
