using AnimalsCare.Data;
using AnimalsCare.Models;
using System;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public  class CommentService : ICommentService
    {
        private readonly ApplicationDbContext db;

        public CommentService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task AddAsync(string id, string userId, string message)
        {
           await  this.db.Comment.AddAsync(new Comment
            {
                BlogId = id,
                CreatedOn = DateTime.UtcNow,
                Message = message,
                UserId = userId,
            });
            await this.db.SaveChangesAsync();
        }
    }
}
