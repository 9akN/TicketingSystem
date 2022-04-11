using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;

namespace TicketingSystem.Repository
{
    public interface ITicketRepository : IBaseRepository<Ticket> {
        List<Ticket> ReadFullTickets();
    }
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(IConfiguration configuration) : base(configuration)
        {
        }

        #region Methods
        /// <summary>
        ///     Method for reading full Tickets with Category, Status, etc. objects.
        /// </summary>
        /// <returns></returns>
        public List<Ticket> ReadFullTickets()
        {
            string sql = @"SELECT t.ticket_id AS Id, t.title AS Title, t.contents AS Content, t.created_at AS DateCreated, t.employee_id AS EmployeeId, t.category_id AS CategoryId, t.status_id AS StatusId,  t.Priority_id AS PriorityId, t.assigned_to AS AssignedTo, t.edited_at AS DateEdited, c.category_id AS Id, c.category_name AS CategoryName, s.status_id AS Id, s.status_name AS StatusName, s.status_color AS StatusColor, p.priority_id AS Id, p.priority_name AS PriorityName, p.priority_color AS PriorityColor FROM tickets t INNER JOIN categories c ON t.category_id = c.category_id  INNER JOIN priorities p ON t.priority_id = p.priority_id INNER JOIN statuses s ON t.status_id = s.status_id;";
            var result = connection.Query<Ticket, Category, Status, Priority, Ticket>(sql, (ticket, category, status, priority) =>
            {
                if (ticket.Category == null)
                {
                    ticket.Category = new();
                }
                if (ticket.Status == null)
                {
                    ticket.Status = new();
                }
                if (ticket.Priority == null)
                {
                    ticket.Priority = new();
                }

                ticket.Category = category;
                ticket.Status = status;
                ticket.Priority = priority;

                return ticket;
            },
            splitOn: "Id,Id,Id,Id");

            return result.ToList();
        } 
        #endregion
    }
}
