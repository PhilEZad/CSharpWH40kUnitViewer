using Domain;

namespace Application.Interfaces;

public interface IUnitService
{
    public List<Unit> GetAllUnits();
    public List<Unit> GetUnitsByFaction(Faction faction);
    public Unit GetUnitById(int id);
    public Unit AddUnit(Unit unit);
    public Boolean UpdateUnit(Unit unit);
    public Boolean DeleteUnit(Unit unit);
}