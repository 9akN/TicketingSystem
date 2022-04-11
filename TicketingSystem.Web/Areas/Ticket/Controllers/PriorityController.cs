using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.Services;

namespace TicketingSystem.Web.Areas.Ticket.Controllers
{
    public class PriorityController : Controller
    {
        #region Dependency injection
        private readonly IPriorityService priorityService;
        #endregion

        #region Methods
        public PriorityController(IPriorityService priorityService)
        {
            this.priorityService = priorityService;
        }

        [HttpGet]
        [Route("Ticket/Priorities")]
        public List<PriorityModel> ReadAll()
        {
            var priorities = priorityService.ReadAll();
            return priorities;
        }

        [HttpGet]
        [Route("Ticket/Priorities/{id}")]
        public PriorityModel ReadById(int id)
        {
            var priority = priorityService.ReadOne(id);
            return priority;
        }

        [HttpPost]
        [Route("Ticket/Priorities/Create")]
        public int? Create([FromBody] PriorityModel priority)
        {
            var p = priorityService.Create(priority);
            return p;
        }

        [HttpPut]
        [Route("Ticket/Priorities/Update")]
        public void Update(PriorityModel priority)
        {
            priorityService.Update(priority);
        }

        [HttpDelete]
        [Route("Ticket/Priorities/Delete")]
        public void Delete([FromBody] PriorityModel priority)
        {
            priorityService.Delete(priority);
        } 
        #endregion
    }
}
