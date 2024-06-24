using FlightReservation_AsyncAwait.Domain.Entities;
using FlightReservation_AsyncAwait.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightReservation_AsyncAwait.Application.Services
{
    public class FlightSearchService : IFlightSearchService
    {
        public async Task<List<Flight>> SearchFlightsAsync(string origin, string destination)
        {
            await Task.Delay(2000);

            return new List<Flight>
            {
                new Flight 
                {
                            FlightNumber = "FL123", 
                            Origin = origin, 
                            Destination = destination, 
                            DepartureTime = DateTime.Now.AddHours(5), 
                            ArrivalTime = DateTime.Now.AddHours(8), 
                            Price = 300 
                },
                new Flight 
                { 
                                FlightNumber = "FL456", 
                                Origin = origin, 
                                Destination = destination, 
                                DepartureTime = DateTime.Now.AddHours(7), 
                                ArrivalTime = DateTime.Now.AddHours(10), 
                                Price = 350 
                }
            };
        }
    }
}
