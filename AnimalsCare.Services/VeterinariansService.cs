using AnimalsCare.Data;
using AnimalsCare.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public class VeterinariansService : IVeterinariansService
    {
        private readonly ApplicationDbContext db;

        public VeterinariansService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<VeterinarianAllViewModel> GetAll()
        {
            return this.db.Veterinarians.Select(x => new VeterinarianAllViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                ImageUrl = x.ImageUrl,
                Info = x.Info,
                Specialty = x.Specialty
            })
                .ToList();
        }
    }
}
