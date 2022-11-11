using Application.Interfaces;
using Domain;

namespace Application;

public class WeaponService : IWeaponService
{
    private IUnitRepository _unitRepository;
    
    public WeaponService(IUnitRepository unitRepository)
    {
        _unitRepository = unitRepository;
    }

    public List<Weapon> GetAllWeapons()
    {
        throw new NotImplementedException();
    }

    public List<Weapon> GetWeaponsByUnit(Unit unit)
    {
        throw new NotImplementedException();
    }

    public List<Weapon> GetWeaponsByFaction(Faction faction)
    {
        throw new NotImplementedException();
    }

    public Weapon GetWeaponById(int id)
    {
        throw new NotImplementedException();
    }

    public void AddWeapon(Weapon weapon)
    {
        throw new NotImplementedException();
    }

    public void UpdateWeapon(Weapon weapon)
    {
        throw new NotImplementedException();
    }

    public void DeleteWeapon(Weapon weapon)
    {
        throw new NotImplementedException();
    }
}