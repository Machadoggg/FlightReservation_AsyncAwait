using FlightReservation_AsyncAwait.Domain.Entities;
using FlightReservation_AsyncAwait.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Application.Services
{
    public class BookingService : IBookingService
    {
        public async Task<string> BookFlightAsync(Flight flight)
        {
            await Task.Delay(2000); // Simulate async operation
            return $"BK{new Random().Next(1000, 9999)}";
        }
    }
}
