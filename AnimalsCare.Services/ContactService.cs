
using AnimalsCare.Data;
using AnimalsCare.Models;
using AnimalsCare.ViewModels;
using AutoMapper;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ContactService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public async Task AddCommentAsync(ContactAddViewModel contactInput)
        {
           await this.db.AddAsync(this.mapper.Map<Contact>(contactInput));
            await this.db.SaveChangesAsync();
        }
    }
}
