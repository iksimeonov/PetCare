
using AnimalsCare.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsCare.Web.ViewComponents
{
    public class OnlineUsersViewComponent : ViewComponent
    {
        private readonly IUsersService usersService;

        public OnlineUsersViewComponent(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public IViewComponentResult Invoke()
        {
            var usersModelCount = this.usersService.GetCountOfUsers();
            return this.View(usersModelCount);
        }
    }
}
