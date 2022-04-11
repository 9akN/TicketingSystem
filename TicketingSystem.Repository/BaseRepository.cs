using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Repository
{
    public interface IBaseRepository<TEntity> { 
        List<TEntity> ReadAll();
        TEntity ReadOne(int id);
        int? Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        #region Dependency injection
        private readonly IConfiguration configuration;
        private readonly string connString;
        public readonly SqlConnection connection;
        #endregion
        #region Constructors
        /// <summary>
        ///  Default constructor
        /// </summary>
        /// <param name="configuration"></param>
        public BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
            connString = configuration.GetConnectionString("MsSql");
            connection = new SqlConnection(connString);
        }
        #endregion
        #region Methods
        /// <summary>
        ///     Create method
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int? Create(TEntity entity)
        {
            return connection.Insert(entity);
        }

        /// <summary>
        ///     Delete method
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(TEntity entity)
        {
            connection.Delete(entity);
        }

        /// <summary>
        ///     Read all method
        /// </summary>
        /// <returns></returns>
        public List<TEntity> ReadAll()
        {
            return connection.GetList<TEntity>().ToList();
        }

        /// <summary>
        ///     Read one method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity ReadOne(int id)
        {
            return connection.Get<TEntity>(id);
        }

        /// <summary>
        ///     Update method
        /// </summary>
        /// <param name="entity"></param>
        public void Update(TEntity entity)
        {
            connection.Update(entity);
        } 
        #endregion
    }
}
