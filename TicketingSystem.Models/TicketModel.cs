using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int EmployeeId { get; set; }
        public int? CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public int? StatusId { get; set; }
        public StatusModel Status { get; set; }
        public int? PriorityId { get; set; }
        public PriorityModel Priority { get; set; }
        public int? AssignedTo { get; set; }
        public DateTimeOffset? DateEdited { get; set; }
    }
}
