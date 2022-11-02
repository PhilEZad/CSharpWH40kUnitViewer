using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class StratagemRepository : IStratagemRepository
{
    private DatabaseContext _dbContext;
    
    public StratagemRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Stratagem> GetAllStratagems()
    {
        throw new NotImplementedException();
    }

    public Stratagem GetStratagemById(int id)
    {
        throw new NotImplementedException();
    }

    public Stratagem GetStratagemByUnit(Unit unit)
    {
        throw new NotImplementedException();
    }

    public Stratagem CreateStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }

    public Stratagem UpdateStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }

    public void DeleteStratagem(int id)
    {
        throw new NotImplementedException();
    }
}