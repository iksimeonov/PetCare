using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class ServicesController : Controller
    {
      public IActionResult Walking()
        {
            return this.View();
        }
    }
}
