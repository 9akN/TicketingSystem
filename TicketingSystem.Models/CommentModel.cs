using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public int EmployeeId { get; set; }
        public int TicketId { get; set; }
    }
}
