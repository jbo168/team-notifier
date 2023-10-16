using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Team.Notifier.DAL
{
    public class GenericRepository : IGenericRepository<T> where T : class
    {
        private readonly TeamNotifierDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = (TeamNotifierDbContext?)dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public IList<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public Task Add(T entity)
        {
            _dbSet.Add(entity);
        }
    }
}
