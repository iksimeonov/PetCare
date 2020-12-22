using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Prices()
        {
            return this.View();
        }
    }
}
