using Domain;

namespace Application.Interfaces;

public interface IUnitRepository
{
    public List<Unit> GetAllUnits();
    public List<Unit> GetUnitsByfaction(Faction faction);
    public Unit GetUnitById(int id);
    public Unit AddUnit(Unit unit);
    public Boolean UpdateUnit(Unit unit);
    public Boolean DeleteUnit(Unit unit);
}