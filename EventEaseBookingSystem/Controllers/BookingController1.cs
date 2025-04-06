using Microsoft.AspNetCore.Mvc;
using EventEaseBookingSystem.Models;

namespace EventEaseBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            var bookings = new List<BookingModel>
            {
                new BookingModel { Id = 1, BookingId = "BK001", EventName = "Tech Conference", VenueName = "City Hall", StartDate = DateTime.Now.AddDays(10), EndDate = DateTime.Now.AddDays(12) },
                new BookingModel { Id = 2, BookingId = "BK002", EventName = "Music Fest", VenueName = "Grand Arena", StartDate = DateTime.Now.AddDays(20), EndDate = DateTime.Now.AddDays(22) }
            };

            return View(bookings);
        }
    }
}