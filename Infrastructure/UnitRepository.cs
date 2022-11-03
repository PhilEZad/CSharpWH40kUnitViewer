using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class UnitRepository : IUnitRepository
{
    private DatabaseContext _dbContext;

    public UnitRepository(DatabaseContext context)
    {
        _dbContext = context;
    }
    
    public List<Unit> GetAllUnits()
    {
        return _dbContext.UnitsTable.ToList();
    }

    public List<Unit> GetUnitsByfaction(Faction faction)
    {
        throw new NotImplementedException();
    }

    public List<Unit> GetUnitsByFaction(Faction faction)
    {
        return _dbContext.UnitsTable.Where(u=>u.Faction == faction).ToList();
    }

    public Unit GetUnitById(int id)
    {
        return _dbContext.UnitsTable.Find(id);
    }

    public Unit AddUnit(Unit unit)
    {
        _dbContext.UnitsTable.Add(unit);
        _dbContext.SaveChanges();
        return unit;
    }

    public Unit UpdateUnit(Unit unit)
    {
        _dbContext.UnitsTable.Update(unit);
        _dbContext.SaveChanges();
        return unit;
    }

    public bool DeleteUnit(Unit unit)
    {
        _dbContext.UnitsTable.Remove(unit);
        _dbContext.SaveChanges();
        return true;
    }
}