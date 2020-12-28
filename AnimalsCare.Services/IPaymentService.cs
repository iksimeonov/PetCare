using System;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public interface IPaymentService
    {
        Task AddAsync(string userId, int package, DateTime date);
    }
}
