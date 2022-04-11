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
    public class RoleController : Controller
    {
        #region Dependency injection
        private readonly IRoleService roleService;
        #endregion

        #region Methods
        public RoleController(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        [HttpGet]
        [Route("Ticket/Roles")]
        public List<RoleModel> ReadAll()
        {
            var roles = roleService.ReadAll();
            return roles;
        }

        [HttpGet]
        [Route("Ticket/Roles/{id}")]
        public RoleModel ReadById(int id)
        {
            var role = roleService.ReadOne(id);
            return role;
        }

        [HttpPost]
        [Route("Ticket/Roles/Create")]
        public int? Create([FromBody] RoleModel role)
        {
            var r = roleService.Create(role);
            return r;
        }

        [HttpPut]
        [Route("Ticket/Roles/Update")]
        public void Update(RoleModel role)
        {
            roleService.Update(role);
        }

        [HttpDelete]
        [Route("Ticket/Roles/Delete")]
        public void Delete([FromBody] RoleModel role)
        {
            roleService.Delete(role);
        } 
        #endregion
    }
}
