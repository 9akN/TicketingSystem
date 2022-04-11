using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;

namespace TicketingSystem.Repository
{
    public interface IPriorityRepository : IBaseRepository<Priority> { 
        
    }
    public class PriorityRepository : BaseRepository<Priority>, IPriorityRepository
    {
        public PriorityRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
