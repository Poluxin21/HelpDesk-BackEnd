namespace HelpDesk.Infra.Data.Repositories;

public interface IUnitOfWork : IDisposable
{
    IQueryable<T> Query<T>() where T : class;
    Task<int> SaveChangesAsync();
}