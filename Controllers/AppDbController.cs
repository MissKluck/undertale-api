using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Characters> Characters { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}