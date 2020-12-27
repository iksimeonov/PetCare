using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface ICommentService
    {
        Task AddAsync(string id, string userId, string message);
    }
}
