using AnimalsCare.Services;
using AnimalsCare.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISeedingVeterinarians seedingService;

        public HomeController(ILogger<HomeController> logger, ISeedingVeterinarians seedingService)
        {
            _logger = logger;
            this.seedingService = seedingService;
        }

        public async Task<IActionResult> Index()
        {
            if (!this.seedingService.Any())
            {
                await this.seedingService.AddVegetariansAsync();
            }
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
