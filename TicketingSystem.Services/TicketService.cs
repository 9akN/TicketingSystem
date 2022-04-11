using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Models;
using TicketingSystem.Repository;

namespace TicketingSystem.Services
{
    public interface ITicketService : IBaseService<Ticket, TicketModel>
    {
        List<TicketModel> ReadFullTickets();
    }
    public class TicketService : BaseService<Ticket, TicketModel>, ITicketService
    {
        private readonly ITicketRepository ticketRepository1;

        public TicketService(IMapper mapper, ITicketRepository ticketRepository) : base(mapper, ticketRepository)
        {
            this.ticketRepository1 = ticketRepository;
        }

        #region Methods
        /// <summary>
        ///     Method for reading full tickets with Category, Status, etc. objects.
        /// </summary>
        /// <returns></returns>
        public List<TicketModel> ReadFullTickets()
        {
            var tickets = ticketRepository1.ReadFullTickets();
            var ticketModels = mapper.Map<List<TicketModel>>(tickets);

            return ticketModels;
        } 
        #endregion
    }
}
