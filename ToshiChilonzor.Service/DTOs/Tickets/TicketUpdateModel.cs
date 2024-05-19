﻿using ToshiChilonzor.Domain.Enums;

namespace ToshiChilonzor.Domain.Entities;

public class TicketUpdateModel 
{
    public long FlightId { get; set; }
    public long UserId { get; set; }
    public SeatStatus Status { get; set; }
    public decimal Price { get; set; }
}
