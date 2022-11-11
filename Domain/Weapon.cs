namespace Domain;

public class Weapon
{
    public Weapon()
    {
        this.Units = new HashSet<Unit>();
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public int Range { get; set; }
    public int Strength { get; set; }
    public int ArmourPiercing { get; set; }
    public int Damage { get; set; }
    public string Type { get; set; }
    public WeaponAbilities WeaponAbilities { get; set; }
    
    public virtual ICollection<Unit> Units { get; set; }
}