using AnimalsCare.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        public async Task<IActionResult> Add(string id, string message)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ;
            await this.commentService.AddAsync(id, userId, message);
            return this.Redirect($"/Blogs/Details/{id}");
        }
    }
}
