using Application.Interfaces;
using Domain;

namespace Application;

public class UnitService : IUnitService 
{
    private IUnitRepository _unitRepository;
    
    public UnitService(IUnitRepository unitRepository)
    {
        _unitRepository = unitRepository;
    }

    public List<Unit> GetAllUnits()
    {
        return _unitRepository.GetAllUnits();
    }

    public List<Unit> GetUnitsByFaction(Faction faction)
    {
        return _unitRepository.GetUnitsByfaction(faction);
    }

    public Unit GetUnitById(int id)
    {
        return _unitRepository.GetUnitById(id);
    }

    public Unit AddUnit(Unit unit)
    {
        return _unitRepository.AddUnit(unit);
    }

    public bool UpdateUnit(Unit unit)
    {
        return _unitRepository.DeleteUnit(unit);
    }

    public bool DeleteUnit(Unit unit)
    {
        return _unitRepository.DeleteUnit(unit);
    }
}