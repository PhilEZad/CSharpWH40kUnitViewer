using Application.Interfaces;
using AutoMapper;
using Domain;

namespace Application;

public class UnitService : IUnitService 
{
    private IUnitRepository _unitRepository;
    private IMapper _mapper;
    
    public UnitService(IUnitRepository unitRepository, IMapper mapper)
    {
        _unitRepository = unitRepository;
        _mapper = mapper;
    }

    public List<Unit> GetAllUnits()
    {
        return _unitRepository.GetAllUnits();
    }

    public List<Unit> GetUnitsByFaction(Faction faction)
    {
        return _unitRepository.GetUnitsByFaction(faction);
    }

    public Unit GetUnitById(int id)
    {
        return _unitRepository.GetUnitById(id);
    }

    public Unit AddUnit(Unit unit)
    {
        return _unitRepository.AddUnit(unit);
    }

    public Unit UpdateUnit(Unit unit)
    {
        return _unitRepository.UpdateUnit(unit);
    }

    public bool DeleteUnit(int id)
    {
        return _unitRepository.DeleteUnit(id);
    }
}