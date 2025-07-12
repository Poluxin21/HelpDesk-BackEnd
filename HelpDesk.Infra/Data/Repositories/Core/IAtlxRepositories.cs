namespace HelpDesk.Infra.Data.Repositories.Core;

public interface IAtlxRepositories<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}