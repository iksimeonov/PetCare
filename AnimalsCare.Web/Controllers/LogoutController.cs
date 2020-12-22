using AnimalsCare.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class LogoutController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public LogoutController(SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public async  Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return this.Redirect("/");
        }
    }
}
