using AnimalsCare.Services;
using AnimalsCare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService blogService;

        public BlogsController(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        public async Task<IActionResult> All()
        {
            var allBlogs = await this.blogService.GetAll();
            return this.View(allBlogs);
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(BlogAddInputViewModel blogAddModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(blogAddModel);
            }
            ;
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.blogService.AddBlog(blogAddModel, userId);

            return this.Redirect("/Blogs/All");
        }

       public async Task<IActionResult> Details(string id)
        {
            var blog = await this.blogService.GetBlogById(id);
            return this.View(blog);
        }

        public async Task<IActionResult> MyBlog()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userCollection = await this.blogService.GetUserBlogs(userId);
            return this.View(userCollection);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var blogForEdit = await this.blogService.GetEditModel(id);
            return  this.View(blogForEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BlogEditViewModel blogEditViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(blogEditViewModel);
            }
            await this.blogService.EditChanges(blogEditViewModel);
            return this.Redirect($"/Blogs/Details?id={blogEditViewModel.Id}");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.blogService.DeleteBlogById(id, userId);
            return this.Redirect("/Blogs/MyBlog");
        }
    }
}
