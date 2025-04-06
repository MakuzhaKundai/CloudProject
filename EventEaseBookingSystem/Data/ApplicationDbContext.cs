using Microsoft.EntityFrameworkCore;
using EventEaseBookingSystem.Models;

namespace EventEaseBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; } // Add this line
        // Add DbSet<EventModel> and DbSet<BookingModel> if needed
    }
}
