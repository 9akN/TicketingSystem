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
    public interface IPriorityService : IBaseService<Priority, PriorityModel> { 
        
    }
    public class PriorityService : BaseService<Priority, PriorityModel>, IPriorityService
    {
        public PriorityService(IMapper mapper, IPriorityRepository priorityRepository) : base(mapper, priorityRepository)
        {
        }
    }
}