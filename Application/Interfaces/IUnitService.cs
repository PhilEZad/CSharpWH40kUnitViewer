using Domain;

namespace Application.Interfaces;

public interface IUnitService
{
    public List<Unit> GetAllUnits();
    public List<Unit> GetUnitsByFaction(Faction faction);
    public Unit GetUnitById(int id);
    public Unit AddUnit(Unit unit);
    public Unit UpdateUnit(Unit unit);
    public bool DeleteUnit(int id);
}