using AnimalsCare.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class VeterinariansController : Controller
    {
        private readonly IVeterinariansService vetService;

        public VeterinariansController(IVeterinariansService vetService)
        {
            this.vetService = vetService;
        }
        public IActionResult All()
        {
            var allVeterianarians =  this.vetService.GetAll();
            return this.View(allVeterianarians);
        }
    }
}
