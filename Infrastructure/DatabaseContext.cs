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
        modelBuilder.Entity<Faction>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
        
        modelBuilder.Entity<Unit>()
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Stratagem>()
            .Property(s => s.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Weapon>()
            .Property(w => w.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<WeaponAbilities>()
            .Property(wa => wa.Id)
            .ValueGeneratedOnAdd();
    }
    
    public DbSet<Faction> FactionsTable { get; set; }
    public DbSet<Unit> UnitsTable { get; set; }
    public DbSet<Stratagem> StrategemTable { get; set; }
    public DbSet<Weapon> WeaponTable { get; set; }
    public DbSet<WeaponAbilities> WeaponAbilitiesTable { get; set; }
}