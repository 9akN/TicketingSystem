using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Models;

namespace TicketingSystem.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<Comment, CommentModel>().ReverseMap();
            CreateMap<Employee, EmployeeModel>().ReverseMap();
            CreateMap<Priority, PriorityModel>().ReverseMap();
            CreateMap<Role, RoleModel>().ReverseMap();
            CreateMap<Status, StatusModel>().ReverseMap();
            CreateMap<Ticket, TicketModel>().ReverseMap();
        }
    }
}
