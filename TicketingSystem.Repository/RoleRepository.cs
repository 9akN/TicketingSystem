using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;

namespace TicketingSystem.Repository
{
    public interface IRoleRepository : IBaseRepository<Role> {
        
    }
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
