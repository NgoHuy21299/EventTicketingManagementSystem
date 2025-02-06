﻿using EventTicketingManagementSystem.Models.BaseModels;

namespace EventTicketingManagementSystem.Models
{
    public class Event : EntityAuditBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public string Category { get; set; }
        public string ArtistInfo { get; set; }
        public string ImageUrls { get; set; }
        public int TotalTickets { get; set; }
        public int RemainingTickets { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
