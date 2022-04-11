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
    public interface IStatusService : IBaseService<Status, StatusModel> { 
        
    }
    public class StatusService : BaseService<Status, StatusModel>, IStatusService
    {
        public StatusService(IMapper mapper, IStatusRepository statusRepository) : base(mapper, statusRepository)
        {
        }
    }
}
