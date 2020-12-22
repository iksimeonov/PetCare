using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface ISeedingVeterinarians
    {
        Task AddVegetariansAsync();
        bool Any();
    }
}
