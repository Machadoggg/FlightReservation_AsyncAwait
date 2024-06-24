using FlightReservation_AsyncAwait.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Domain.Interfaces
{
    public interface IFlightSearchService
    {
        public interface IFlightSearchService
        {
            Task<List<Flight>> SearchFlightsAsync(string origin, string destination);
        }
    }
}
