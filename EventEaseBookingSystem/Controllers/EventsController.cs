using Microsoft.AspNetCore.Mvc;
using EventEaseBookingSystem.Models;

namespace EventEaseBookingSystem.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            var events = new List<EventModel>
            {
                new EventModel { Id = 1, Name = "Tech Conference", Date = DateTime.Now.AddMonths(1), VenueId = 1, ImageUrl = "https://via.placeholder.com/300x200?text=Event+1" },
                new EventModel { Id = 2, Name = "Music Fest", Date = DateTime.Now.AddMonths(2), VenueId = 2, ImageUrl = "https://via.placeholder.com/300x200?text=Event+2" }
            };

            return View(events);
        }
    }
}


