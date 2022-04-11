using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.Services;

namespace TicketingSystem.Web.Areas.Ticket.Controllers
{
    [Area("Ticket")]
    public class CategoryController : Controller
    {
        #region Dependency injection
        private readonly ICategoryService categoryService;
        #endregion

        #region Methods
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        [Route("Ticket/Categories")]
        public List<CategoryModel> ReadAll()
        {
            var categories = categoryService.ReadAll();
            return categories;
        }

        [HttpGet]
        [Route("Ticket/Categories/{id}")]
        public CategoryModel ReadById(int id)
        {
            var category = categoryService.ReadOne(id);
            return category;
        }

        [HttpPost]
        [Route("Ticket/Categories/Create")]
        public int? Create([FromBody] CategoryModel category)
        {
            var c = categoryService.Create(category);
            return c;
        }

        [HttpPut]
        [Route("Ticket/Categories/Update")]
        public void Update(CategoryModel category)
        {
            categoryService.Update(category);
        }

        [HttpDelete]
        [Route("Ticket/Categories/Delete")]
        public void Delete([FromBody] CategoryModel category)
        {
            categoryService.Delete(category);
        } 
        #endregion
    }
}
