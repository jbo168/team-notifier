namespace Team.Notifier.DAL;

public interface IUnitOfWork : IDisposable
{
    void Commit();

    void Rollback();
    
    IGenericRepository<T> Repository<T>() where T : class;
}