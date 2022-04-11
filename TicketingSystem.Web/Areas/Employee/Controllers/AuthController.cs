using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Services;
using TicketingSystem.Models;

namespace TicketingSystem.Web.Areas.Employee.Controllers
{
    [Area("Employee")]
    //[Route("Employee/[controller]/[action]")]
    public class AuthController : Controller
    {
        private readonly IEmployeeService employeeService;
        public AuthController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpGet]
        [Route("Employee/Auth/Employees")]
        public List<EmployeeModel> Employees()
        {
            var employees = employeeService.ReadAll();
            return employees;
        }
    }
}
