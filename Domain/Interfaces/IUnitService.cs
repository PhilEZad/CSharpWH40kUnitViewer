using Domain;

namespace Application.Interfaces;

public interface IUnitService
{
    public List<Unit> GetAllUnits();
    public Unit GetUnitById(int id);
    public Boolean AddUnit(Unit unit);
    public Boolean UpdateUnit(Unit unit);
    public Boolean DeleteUnit(int id);
}