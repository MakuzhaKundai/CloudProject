﻿namespace EventEaseBookingSystem.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int VenueId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}