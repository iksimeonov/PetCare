using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class ServicesController : Controller
    {
      public IActionResult DogWalking()
        {
            return this.View();
        }
        public IActionResult PetDaycare()
        {
            return this.View();
        }

        public IActionResult PetGrooming()
        {
            return this.View();
        }
    }
}
