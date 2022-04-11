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
    [Area("Ticket")]
    public class StatusController : Controller
    {
        #region Dependency injection
        private readonly IStatusService statusService;
        #endregion

        #region Methods
        public StatusController(IStatusService statusService)
        {
            this.statusService = statusService;
        }

        [HttpGet]
        [Route("Ticket/Statuses")]
        public List<StatusModel> ReadAll()
        {
            var statuses = statusService.ReadAll();
            return statuses;
        }

        [HttpGet]
        [Route("Ticket/Statuses/{id}")]
        public StatusModel ReadById(int id)
        {
            var status = statusService.ReadOne(id);
            return status;
        }

        [HttpPost]
        [Route("Ticket/Statuses/Create")]
        public int? Create([FromBody] StatusModel role)
        {
            var s = statusService.Create(role);
            return s;
        }

        [HttpPut]
        [Route("Ticket/Statuses/Update")]
        public void Update(StatusModel status)
        {
            statusService.Update(status);
        }

        [HttpDelete]
        [Route("Ticket/Statuses/Delete")]
        public void Delete([FromBody] StatusModel status)
        {
            statusService.Delete(status);
        } 
        #endregion
    }
}
