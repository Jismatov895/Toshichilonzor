using ToshiChilonzor.Domain.Commons;
using ToshiChilonzor.Domain.Enums;

namespace ToshiChilonzor.Domain.Entities;

public class Ticket : Auditable
{
    public long FlightId { get; set; }
    public Flight Flight { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public SeatStatus Status { get; set; }
    public decimal Price { get; set; }
}
