using AnimalsCare.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface IBlogService
    {
        Task AddBlog(BlogAddInputViewModel blogAddModel, string userId);
        Task<IEnumerable<BlogsAllViewModel>> GetAll();
        Task<BlogDetailsViewModel> GetBlogById(string id);
        Task<IEnumerable<BlogsAllViewModel>> GetUserBlogs(string userId);
        Task EditChanges(BlogEditViewModel blogEditViewModel);
        Task<BlogEditViewModel> GetEditModel(string id);
        Task DeleteBlogById(string id, string userId);
    }
}
