using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class FactionRepository : IFactionRepository
{
    private DatabaseContext _dbContext;
    
    public FactionRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public List<Faction> GetAllFactions()
    {
        return _dbContext.FactionsTable.ToList();
    }

    public Faction CreateFaction(Faction faction)
    {
        _dbContext.FactionsTable.Add(faction);
        _dbContext.SaveChanges();
        return faction;
    }

    public Faction UpdateFaction(Faction faction)
    {
        _dbContext.FactionsTable.Update(faction);
        _dbContext.SaveChanges();
        return faction;
    }

    public Faction GetFactionById(int id)
    {
        return _dbContext.FactionsTable.Find(id);
    }

    public Boolean DeleteFaction(Faction faction)
    {
        _dbContext.FactionsTable.Remove(faction);
        _dbContext.SaveChanges();
        return true;
    }
    
    public void BuildDb()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();
    }
}