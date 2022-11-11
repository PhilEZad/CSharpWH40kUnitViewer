namespace Domain;

public class Unit
{
    public Unit()
    {
        this.Weapons = new HashSet<Weapon>();
    }
    public int Id  { get; set; }
    public Faction Faction { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<Weapon> Weapons { get; set; }
}