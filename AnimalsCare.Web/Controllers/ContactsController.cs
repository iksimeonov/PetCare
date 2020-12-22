using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.Controllers
{
    public class ContactsController : Controller
    {

        public IActionResult Contact()
        {
            return this.View();
        }
    }
}
