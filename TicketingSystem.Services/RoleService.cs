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
    public interface IRoleService : IBaseService<Role, RoleModel> { 
        
    }
    public class RoleService : BaseService<Role, RoleModel>, IRoleService
    {
        public RoleService(IMapper mapper, IRoleRepository roleRepository) : base(mapper, roleRepository)
        {
        }
    }
}
