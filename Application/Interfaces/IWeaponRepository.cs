using Domain;

namespace Application.Interfaces;

public interface IWeaponRepository
{
    public List<Weapon> GetAllWeapons();
    public List<Weapon> GetWeaponsByUnit(Unit unit);
    public List<Weapon> GetWeaponsByFaction(Faction faction);
    public Weapon GetWeaponById(int id);
    public void AddWeapon(Weapon weapon);
    public void UpdateWeapon(Weapon weapon);
    public void DeleteWeapon(Weapon weapon);
}