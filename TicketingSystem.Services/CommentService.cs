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
    public interface ICommentService : IBaseService<Comment, CommentModel> {
        List<CommentModel> ReadByTicketId(int id);
    }
    public class CommentService : BaseService<Comment, CommentModel>, ICommentService
    {
        public ICommentRepository commentRepository1;
        public CommentService(IMapper mapper, ICommentRepository commentRepository) : base(mapper, commentRepository)
        {
            this.commentRepository1 = commentRepository;
        }

        #region Methods
        /// <summary>
        ///     Method for reading comments by TicketId.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CommentModel> ReadByTicketId(int id)
        {
            var comments = commentRepository1.ReadByTicketId(id);
            var commentsModel = mapper.Map<List<CommentModel>>(comments);

            return commentsModel;
        } 
        #endregion
    }
}
