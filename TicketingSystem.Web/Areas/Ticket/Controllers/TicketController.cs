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
    public class TicketController : Controller
    {
        #region Dependency injection
        private readonly ITicketService ticketService;
        #endregion

        #region Methods
        public TicketController(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        [HttpGet]
        [Route("Ticket/Tickets")]
        public List<TicketModel> ReadAll()
        {
            var tickets = ticketService.ReadAll();
            return tickets;
        }

        [HttpGet]
        [Route("Ticket/FullTickets")]
        public List<TicketModel> ReadFullTickets()
        {
            var tickets = ticketService.ReadFullTickets();
            return tickets;
        }

        [HttpGet]
        [Route("Ticket/Tickets/{id}")]
        public TicketModel ReadById(int id)
        {
            var ticket = ticketService.ReadOne(id);
            return ticket;
        }

        [HttpPost]
        [Route("Ticket/Tickets/Create")]
        public int? Create([FromBody] TicketModel ticket)
        {
            var t = ticketService.Create(ticket);
            return t;
        }

        [HttpPut]
        [Route("Ticket/Tickets/Update")]
        public void Update(TicketModel ticket)
        {
            ticketService.Update(ticket);
        }

        [HttpDelete]
        [Route("Ticket/Tickets/Delete")]
        public void Delete([FromBody] TicketModel ticket)
        {
            ticketService.Delete(ticket);
        } 
        #endregion
    }
}
