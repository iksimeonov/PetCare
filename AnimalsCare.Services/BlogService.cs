using AnimalsCare.Data;
using AnimalsCare.Models;
using AnimalsCare.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public BlogService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public async Task AddBlog(BlogAddInputViewModel blogAddModel, string userId)
        {
            var blog = this.mapper.Map<Blog>(blogAddModel);
            blog.CreatorId = userId;
            await this.db.Blogs.AddAsync(blog);
            await this.db.SaveChangesAsync();
        }

        public async Task DeleteBlogById(string id, string userId)
        {
            var blog = this.db.Blogs.FirstOrDefault(x => x.Id == id);
            this.db.Users.FirstOrDefault(x => x.Id == userId).Blogs.Remove(blog);
           await this.db.SaveChangesAsync();
        }

        public async Task EditChanges(BlogEditViewModel blogEditViewModel)
        {
            var blog = this.db.Blogs.FirstOrDefault(x => x.Id == blogEditViewModel.Id);
            blog.Description = blogEditViewModel.Description;
            blog.Title = blogEditViewModel.Title;
            blog.ImageUrl = blogEditViewModel.ImageUrl;
           await this.db.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogsAllViewModel>> GetAll()
        {
            return  this.db.Blogs.ProjectTo<BlogsAllViewModel>(this.mapper.ConfigurationProvider)
                                .ToList();
            
        }

        public async Task<BlogDetailsViewModel> GetBlogById(string id)
        {
            return this.db.Blogs.Where(x => x.Id == id)
                          .Select(x => new BlogDetailsViewModel
                          {
                              Id = x.Id,
                              CreatedOn = x.CreatedOn,
                              CreatorUsername = x.Creator.UserName,
                              Description = x.Description,
                              ImageUrl = x.ImageUrl,
                              Title = x.Title,
                              Comments = x.Comments.Select(c => new CommentPostViewModel
                              {
                                  CreatedOn = c.CreatedOn,
                                  Message = c.Message,
                                  UserUsername = c.User.UserName
                              })
                                     .ToList()
                          })
                          .FirstOrDefault();
        }

        public async Task<BlogEditViewModel> GetEditModel(string id)
        {
            return  this.mapper.Map<BlogEditViewModel>(this.db.Blogs.FirstOrDefault(x => x.Id == id));
        }

        public  IEnumerable<LastBlogsViewModels> GetLastBlogs()
        {
            return this.db.Blogs.ProjectTo<LastBlogsViewModels>(this.mapper.ConfigurationProvider)
                                 .ToList()
                                 .TakeLast(3);
        }

        public async Task<IEnumerable<BlogsAllViewModel>> GetUserBlogs(string userId)
        {
            return  this.db.Blogs.Where(x=>x.CreatorId==userId).ProjectTo<BlogsAllViewModel>(this.mapper.ConfigurationProvider)
                               .ToList();
        }
    }
}
