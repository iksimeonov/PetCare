

using AnimalsCare.Data;
using AnimalsCare.ViewModels;
using System.Linq;

namespace AnimalsCare.Services
{
  public  class UsersService : IUsersService
    {
        private readonly ApplicationDbContext db;

        public UsersService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public UsersCountComponentViewModel GetCountOfUsers()
        {
            return this.db.Users.Select(x => new UsersCountComponentViewModel
            {
                Count = this.db.Users.Count()
            })
            .FirstOrDefault();
            
        }
    }
}
