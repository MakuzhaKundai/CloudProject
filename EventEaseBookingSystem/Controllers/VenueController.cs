using Microsoft.AspNetCore.Mvc;
using EventEaseBookingSystem.Models;

namespace EventEaseBookingSystem.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            var venues = new List<Venue>
            {
                new Venue { Id = 1, Name = "City Hall", Location = "Downtown", Capacity = 300, ImageUrl = "https://via.placeholder.com/300x200?text=Venue+1" },
                new Venue { Id = 2, Name = "Grand Arena", Location = "Uptown", Capacity = 1000, ImageUrl = "https://via.placeholder.com/300x200?text=Venue+2" }
            };

            return View(venues);
        }
    }
}
