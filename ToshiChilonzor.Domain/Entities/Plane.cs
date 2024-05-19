using ToshiChilonzor.Domain.Commons;

namespace ToshiChilonzor.Domain.Entities;

public class Plane : Auditable
{
    public string Number { get; set; }
    public int EconomSeats { get; set; }
    public int BusinessSeats { get; set; }
}
