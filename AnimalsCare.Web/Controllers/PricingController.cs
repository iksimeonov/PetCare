using AnimalsCare.Services;
using AnimalsCare.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class PricingController : Controller
    {
        private readonly IPaymentService paymentService;

        public PricingController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        public IActionResult Prices()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Payment()
        {
            return this.View();
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Payment(UserPaymentViewModel paymentModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(paymentModel);
            }
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.paymentService.AddAsync(userId, paymentModel.Package, paymentModel.Date);

            this.TempData["Success"] = "True";
            return this.View("Prices");

            //return this.Redirect("/");
        }
    }
}
