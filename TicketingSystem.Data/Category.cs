using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    [Table("categories")]
    public class Category
    {
        [Column("category_id")]
        public int Id { get; set; }
        [Column("category_name")]
        public string CategoryName { get; set; }
    }
}
