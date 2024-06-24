using FlightReservation_AsyncAwait.Domain.Interfaces;

namespace FlightReservation_AsyncAwait.Presentation
{
    public class FlightBookingApp
    {
        private readonly IFlightSearchService _flightSearchService;
        private readonly IBookingService _bookingService;
        private readonly IPaymentService _paymentService;

        public FlightBookingApp(IFlightSearchService flightSearchService, IBookingService bookingService, IPaymentService paymentService)
        {
            _flightSearchService = flightSearchService;
            _bookingService = bookingService;
            _paymentService = paymentService;
        }

        public async Task RunAsync()
        {
            Console.WriteLine("Buscando vuelos...");
            var flights = await _flightSearchService.SearchFlightsAsync("NYC", "LAX");

            Console.WriteLine("Vuelos encontrados:");
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.FlightNumber} - {flight.Origin} a {flight.Destination} - {flight.Price:C}");
            }

            var selectedFlight = flights.First();
            Console.WriteLine($"\nReservando vuelo {selectedFlight.FlightNumber}...");

            var bookingNumber = await _bookingService.BookFlightAsync(selectedFlight);
            Console.WriteLine($"Reserva completada. Número de reserva: {bookingNumber}");

            Console.WriteLine($"Procesando pago de {selectedFlight.Price:C}...");
            var paymentSuccess = await _paymentService.ProcessPaymentAsync(selectedFlight.Price);

            if (paymentSuccess)
            {
                Console.WriteLine("Pago procesado exitosamente.");
            }
            else
            {
                Console.WriteLine("Fallo en el procesamiento del pago.");
            }
        }
    }
}
