

using AnimalsCare.ViewModels;

namespace AnimalsCare.Services
{
    public interface IUsersService
    {
        UsersCountComponentViewModel GetCountOfUsers();
    }
}
