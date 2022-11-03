using Domain;

namespace Application.Interfaces;

public interface IStratagemRepository
{
    public List<Stratagem> GetAllStratagems();
    public Stratagem GetStratagemById(int id);
    public Stratagem GetStratagemByUnit(Unit unit);
    public Stratagem CreateStratagem(Stratagem stratagem);
    public Stratagem UpdateStratagem(Stratagem stratagem);
    public Boolean DeleteStratagem(Stratagem stratagem);
}