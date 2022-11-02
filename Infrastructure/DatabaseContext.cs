using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Unit>()
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Faction>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Stratagem>()
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();
    }
    
    public DbSet<Faction> FactionsTable { get; set; }
    public DbSet<Unit> UnitsTable { get; set; }
    public DbSet<Stratagem> StrategemTable { get; set; }
}