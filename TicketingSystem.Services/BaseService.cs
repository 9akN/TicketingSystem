using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Repository;

namespace TicketingSystem.Services
{
    public interface IBaseService<TInput, TOutput>
    {
        List<TOutput> ReadAll();
        TOutput ReadOne(int id);
        int? Create(TOutput employee);
        void Update(TOutput employee);
        void Delete(TOutput employee);
    }
    public class BaseService<TInput, TOutput> : IBaseService<TInput, TOutput>
    {
        #region Dependency injection
        public readonly IMapper mapper;
        private readonly IBaseRepository<TInput> baseRepository;
        #endregion

        #region Constructor
        public BaseService(IMapper mapper, IBaseRepository<TInput> baseRepository)
        {
            this.mapper = mapper;
            this.baseRepository = baseRepository;
        } 
        #endregion

        #region Methods
        /// <summary>
        ///     Create method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public int? Create(TOutput employee)
        {
            return baseRepository.Create(mapper.Map<TInput>(employee));
        }
        /// <summary>
        ///     Delete method
        /// </summary>
        /// <param name="employee"></param>
        public void Delete(TOutput employee)
        {
            baseRepository.Delete(mapper.Map<TInput>(employee));
        }
        /// <summary>
        ///     Read all method
        /// </summary>
        /// <returns></returns>
        public List<TOutput> ReadAll()
        {
            var employees = baseRepository.ReadAll();
            var employeeModels = mapper.Map<List<TOutput>>(employees);

            return employeeModels;
        }
        /// <summary>
        ///     Read by id method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TOutput ReadOne(int id)
        {
            var employee = baseRepository.ReadOne(id);
            var employeeModel = mapper.Map<TOutput>(employee);

            return employeeModel;
        }
        /// <summary>
        ///     Update method
        /// </summary>
        /// <param name="employee"></param>
        public void Update(TOutput employee)
        {
            baseRepository.Update(mapper.Map<TInput>(employee));
        }
        #endregion
    }
}
