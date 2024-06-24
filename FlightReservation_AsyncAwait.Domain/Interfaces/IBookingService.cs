using FlightReservation_AsyncAwait.Domain.Entities;
using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Domain.Interfaces
{
    public interface IBookingService
    {
        Task<string> BookFlightAsync(Flight flight);
    }
}
