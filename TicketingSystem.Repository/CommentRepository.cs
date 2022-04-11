using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Data;

namespace TicketingSystem.Repository
{
    public interface ICommentRepository : IBaseRepository<Comment> { 
        List<Comment> ReadByTicketId(int id);
    }
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(IConfiguration configuration) : base(configuration)
        {

        }

        #region Methods
        /// <summary>
        ///     Method for reading comments by TicketId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Comment> ReadByTicketId(int id)
        {
            string sql = $"SELECT c.comment_id AS Id, c.the_content AS Content, c.employee_id AS EmployeeId, c.ticket_id AS TicketId FROM comments c WHERE c.ticket_id = {id};";
            var result = connection.Query<Comment>(sql);

            return result.ToList();
        } 
        #endregion
    }
}
