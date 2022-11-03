using Domain;

namespace Application.Interfaces;

public interface IUnitRepository
{
    public List<Unit> GetAllUnits();
    public List<Unit> GetUnitsByFaction(Faction faction);
    public Unit GetUnitById(int id);
    public Unit AddUnit(Unit unit);
    public Unit UpdateUnit(Unit unit);
    public bool DeleteUnit(Unit unit);
}