
using FlightReservation_AsyncAwait.Application.Services;
using FlightReservation_AsyncAwait.Domain.Interfaces;
using FlightReservation_AsyncAwait.Presentation;

IFlightSearchService flightSearchService = new FlightSearchService();
IBookingService bookingService = new BookingService();
IPaymentService paymentService = new PaymentService();

var app = new FlightBookingApp(flightSearchService, bookingService, paymentService);
await app.RunAsync();