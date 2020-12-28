using AnimalsCare.ViewModels;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface IConsultationService
    {
        Task AddAsync(ConsultationAddViewModel consultAddModel);
    }
}
