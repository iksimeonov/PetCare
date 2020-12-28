using AnimalsCare.Services;
using AnimalsCare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class ConsultationsController : Controller
    {
        private readonly IConsultationService consultationService;

        public ConsultationsController(IConsultationService consultationService)
        {
            this.consultationService = consultationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConsultationAddViewModel consultAddModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/");
            }
            await this.consultationService.AddAsync(consultAddModel);

            return this.Redirect("/");
        }
    }
}
