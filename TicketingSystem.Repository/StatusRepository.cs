using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;

namespace TicketingSystem.Repository
{
    public interface IStatusRepository : IBaseRepository<Status> { 
        
    }
    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        public StatusRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
