using FlightReservation_AsyncAwait.Domain.Interfaces;
using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Application.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> ProcessPaymentAsync(decimal amount)
        {
            await Task.Delay(3000); // Simulate async operation
            return true;
        }
    }
}
