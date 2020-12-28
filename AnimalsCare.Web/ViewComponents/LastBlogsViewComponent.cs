using AnimalsCare.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalsCare.Web.ViewComponents
{
    public class LastBlogsViewComponent : ViewComponent
    {
        private readonly IBlogService blogService;

        public LastBlogsViewComponent(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        public  IViewComponentResult Invoke()
        {
            var lastBlogs =  this.blogService.GetLastBlogs();
            return this.View(lastBlogs);
        }
    }
}
