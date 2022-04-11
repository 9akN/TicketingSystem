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
    public interface IEmployeeService : IBaseService<Employee, EmployeeModel>
    {
        #region Old code
        /*
        List<EmployeeModel> ReadAll();
        EmployeeModel ReadOne(int id);
        int? Create(EmployeeModel employee);
        void Update(EmployeeModel employee);
        void Delete(EmployeeModel employee);*/ 
        #endregion
    }
    public class EmployeeService : BaseService<Employee, EmployeeModel>, IEmployeeService
    {
        #region Old code
        /*
        #region Dependency injection
        private readonly IEmployeeRepository employeeRepository;
        #endregion

        #region Constructor
        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository) : base(mapper)
        {
            this.employeeRepository = employeeRepository;
        } 
        #endregion

        #region Functions
        public int? Create(EmployeeModel employee)
        {
            return employeeRepository.Create(mapper.Map<Employee>(employee));
        }

        public void Delete(EmployeeModel employee)
        {
            employeeRepository.Delete(mapper.Map<Employee>(employee));
        }

        public List<EmployeeModel> ReadAll()
        {
            var employees = employeeRepository.ReadAll();
            var employeeModels = mapper.Map<List<EmployeeModel>>(employees);

            return employeeModels;
        }

        public EmployeeModel ReadOne(int id)
        {
            var employee = employeeRepository.ReadOne(id);
            var employeeModel = mapper.Map<EmployeeModel>(employee);

            return employeeModel;
        }

        public void Update(EmployeeModel employee)
        {
            employeeRepository.Update(mapper.Map<Employee>(employee));
        } 
        #endregion
    }*/ 
        #endregion
        public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository) : base(mapper, employeeRepository)
        {

        }
    }
}
