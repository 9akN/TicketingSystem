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
    public class CommentController : Controller
    {
        #region Dependency injection
        private readonly ICommentService commentService;
        #endregion

        #region Methods
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpGet]
        [Route("Ticket/Comments")]
        public List<CommentModel> ReadAll()
        {
            var comments = commentService.ReadAll();
            return comments;
        }

        [HttpGet]
        [Route("Ticket/Comments/{id}")]
        public CommentModel ReadById(int id)
        {
            var comment = commentService.ReadOne(id);
            return comment;
        }

        [HttpGet]
        [Route("Ticket/Comments/ByTicketId/{id}")]
        public List<CommentModel> ReadByTicketId(int id)
        {
            var comment = commentService.ReadByTicketId(id);
            return comment;
        }

        [HttpPost]
        [Route("Ticket/Comments/Create")]
        public int? Create([FromBody] CommentModel comment)
        {
            var c = commentService.Create(comment);
            return c;
        }

        [HttpPut]
        [Route("Ticket/Comments/Update")]
        public void Update(CommentModel comment)
        {
            commentService.Update(comment);
        }

        [HttpDelete]
        [Route("Ticket/Comments/Delete")]
        public void Delete([FromBody] CommentModel comment)
        {
            commentService.Delete(comment);
        } 
        #endregion
    }
}
