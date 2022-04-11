using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("ticket_id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("contents")]
        public string Content { get; set; }
        [Column("created_at")]
        public DateTimeOffset DateCreated { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        [Column("status_id")]
        public int? StatusId { get; set; }
        public Status Status { get; set; }
        [Column("priority_id")]
        public int? PriorityId { get; set; }
        public Priority Priority { get; set; }
        [Column("assigned_to")]
        public int? AssignedTo { get; set; }
        [Column("edited_at")]
        public DateTimeOffset? DateEdited { get; set; }
    }
}
