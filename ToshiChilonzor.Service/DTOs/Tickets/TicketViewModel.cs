using ToshiChilonzor.Domain.Enums;

namespace ToshiChilonzor.Domain.Entities;

public class TicketViewModel 
{
    public long Id { get; set; }
    public FlightViewModel Flight { get; set; }
    public UserViewModel User { get; set; }
    public SeatStatus Status { get; set; }
    public decimal Price { get; set; }
}
