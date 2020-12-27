using AnimalsCare.Services;
using AnimalsCare.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalsCare.Web.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactService commentService;

        public ContactsController(IContactService commentService)
        {
            this.commentService = commentService;
        }

        public IActionResult Contact()
        {
            return this.View();
        } 

        [HttpPost]
        public async Task<IActionResult> Contact(ContactAddViewModel commentInput)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(commentInput);
            }
            await this.commentService.AddCommentAsync(commentInput);
            return this.Redirect("/Contacts/Contact");
        }
    }
}
