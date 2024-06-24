using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Domain.Interfaces
{
    public interface IPaymentService
    {
        Task<bool> ProcessPaymentAsync(decimal amount);
    }
}
