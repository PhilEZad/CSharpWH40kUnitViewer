using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class WeaponsRepository : IWeaponRepository
{
    private DatabaseContext _context;
    
    public WeaponsRepository(DatabaseContext context)
    {
        _context = context;
    }


    public List<Weapon> GetAllWeapons()
    {
        return _context.WeaponTable.ToList();
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
        return _context.WeaponTable.Find(id);
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