using System;

namespace FlightReservation_AsyncAwait.Domain.Entities
{
    public class Flight
    {
        public string FlightNumber { get; set; } = default!;
        public string Origin { get; set; } = default!;
        public string Destination { get; set; } = default!;
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
    }
}
