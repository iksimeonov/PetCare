using AnimalsCare.Data;
using AnimalsCare.Models;
using System;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ApplicationDbContext db;

        public PaymentService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task AddAsync(string userId, int package, DateTime date)
        {
            await this.db.Payments.AddAsync(new Payment
            {
                CreatedOn = DateTime.UtcNow,
                Price = package,
                UserId = userId,
                Date = date
            });
            await this.db.SaveChangesAsync();

        }
    }
}
