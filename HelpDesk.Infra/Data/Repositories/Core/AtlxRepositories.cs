namespace HelpDesk.Infra.Data.Repositories.Core;

public class AtlxRepositories<T> : IAtlxRepositories<T> where T : class
{
    private readonly AppDbContext _context;
    
    public AtlxRepositories(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<T> GetByIdAsync(Guid id)
    => await _context.Set<T>().FindAsync(id);

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}