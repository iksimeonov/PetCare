using AnimalsCare.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface IVeterinariansService
    {
        IEnumerable<VeterinarianAllViewModel> GetAll();
    }
}
