using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class UnitRepository : IUnitRepository
{
    private DatabaseContext _DBcontext;

    public UnitRepository(DbContext context)
    {
            _DBcontext = (DatabaseContext)context;
    }
    
    public List<Unit> GetAllUnits()
    {
        return _DBcontext.UnitsTable.ToList();
    }

    public List<Unit> GetUnitsByfaction(Faction faction)
    {
        return _DBcontext.UnitsTable.Where(u=>u.Faction == faction).ToList();
    }

    public Unit GetUnitById(int id)
    {
        return _DBcontext.UnitsTable.Find(id);
    }

    public Unit AddUnit(Unit unit)
    {
        _DBcontext.UnitsTable.Add(unit);
        _DBcontext.SaveChanges();
        return unit;
    }

    public bool UpdateUnit(Unit unit)
    {
        _DBcontext.UnitsTable.Update(unit);
        _DBcontext.SaveChanges();
        return true;
    }

    public bool DeleteUnit(Unit unit)
    {
        _DBcontext.UnitsTable.Remove(unit);
        _DBcontext.SaveChanges();
        return true;
    }
}