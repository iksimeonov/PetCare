using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class InfoController : Controller
    {


        public IActionResult Gallery()
        {
            return this.View();
        }
    }
}
