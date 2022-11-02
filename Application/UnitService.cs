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
    
    public List<Unit> GetUnits()
    {
        return _unitRepository.GetUnits();
    }

    public List<Unit> GetAllUnits()
    {
        throw new NotImplementedException();
    }

    public Unit GetUnitById(int id)
    {
        throw new NotImplementedException();
    }

    public bool AddUnit(Unit unit)
    {
        throw new NotImplementedException();
    }

    public bool UpdateUnit(Unit unit)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUnit(int id)
    {
        throw new NotImplementedException();
    }
}