﻿namespace EventEaseBookingSystem.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string ImageUrl { get; set; } = string.Empty; // Use placeholder image
    }
}
