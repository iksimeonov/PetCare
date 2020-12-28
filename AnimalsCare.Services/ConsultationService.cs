
using AnimalsCare.Data;
using AnimalsCare.Models;
using AnimalsCare.ViewModels;
using AutoMapper;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
  public  class ConsultationService  : IConsultationService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ConsultationService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public async Task AddAsync(ConsultationAddViewModel consultAddModel)
        {
            await this.db.Consultations.AddAsync(this.mapper.Map<Consultation>(consultAddModel));
            await this.db.SaveChangesAsync();
        }
    }
}
