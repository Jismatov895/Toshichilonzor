using Microsoft.EntityFrameworkCore;

namespace ToshiChilonzor.Data.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost; Database=Airway; Port=5432; User ID=postgres; Password=1001");
    }
}
