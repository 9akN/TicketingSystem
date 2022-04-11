using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.Services;

namespace TicketingSystem.Web.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class EmployeeController : Controller
    {
        #region Dependency injection
        private readonly IEmployeeService employeeService;
        #endregion

        #region Methods
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        [Route("Employee/Employees")]
        public List<EmployeeModel> ReadAll()
        {
            var employees = employeeService.ReadAll();
            return employees;
        }

        [HttpGet]
        [Route("Employee/Employees/{id}")]
        public EmployeeModel ReadById(int id)
        {
            var employee = employeeService.ReadOne(id);
            return employee;
        }

        [HttpPost]
        [Route("Employee/Employees/Create")]
        public int? Create([FromBody] EmployeeModel employee)
        {
            var emp = employeeService.Create(employee);
            return emp;
        }

        [HttpPut]
        [Route("Employee/Employees/Update")]
        public void Update(EmployeeModel employee)
        {
            employeeService.Update(employee);
        }

        [HttpDelete]
        [Route("Employee/Employees/Delete")]
        public void Delete([FromBody] EmployeeModel employee)
        {
            employeeService.Delete(employee);
        } 
        #endregion
    }
}
