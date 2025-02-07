﻿namespace EventTicketingManagementSystem.Dtos
{
    public class TicketInfoDto
    {
        public int TicketId { get; set; }
        public string? EventName { get; set; }
        public decimal TicketPrice { get; set; }
        public string? TicketNumber { get; set; }
        public string? SeatType { get; set; }
        public string? Status { get; set; }
    }
}
