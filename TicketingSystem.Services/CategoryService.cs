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
    public interface ICategoryService : IBaseService<Category, CategoryModel> { 
        
    }
    public class CategoryService : BaseService<Category, CategoryModel>, ICategoryService
    {
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository) : base(mapper, categoryRepository)
        {
        }
    }
}
