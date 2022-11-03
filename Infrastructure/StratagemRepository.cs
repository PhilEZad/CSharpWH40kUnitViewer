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
        return _dbContext.StrategemTable.ToList();
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
        _dbContext.StrategemTable.Add(stratagem);
        _dbContext.SaveChanges();
        return stratagem;
    }

    public Stratagem UpdateStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }

    public bool DeleteStratagem(Stratagem stratagem)
    {
        _dbContext.StrategemTable.Remove(stratagem);
        _dbContext.SaveChanges();
        return true;
    }
}