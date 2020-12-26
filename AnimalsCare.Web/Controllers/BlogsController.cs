using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult All()
        {
            return this.View();
        }

        public IActionResult Add()
        {
            return this.View();
        }

    }
}
