using AnimalsCare.ViewModels;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface IContactService
    {
        Task AddCommentAsync(ContactAddViewModel commentInput);
    }
}
