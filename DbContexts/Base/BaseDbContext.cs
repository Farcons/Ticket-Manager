using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TicketManager.Data.Casos;
using TicketManager.Data.Clientes;

namespace TicketManager.DbContexts.Base
{
    public class BaseDbContext<TEntity> : IBaseDbContext<TEntity> where TEntity : SystemBaseIdentifier
    {
        protected readonly AppDbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseDbContext(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> Search()
        {
            return _dbContext.Set<TEntity>();
        }

        public List<TEntity> List()
        {
            return [.. _dbContext.Set<TEntity>()];
        }

        public void AddRange(List<TEntity> entity)
        {
            _dbContext.Set<TEntity>().AddRange(entity);
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public TEntity FirstOrDefault()
        {
            return _dbContext.Set<TEntity>().FirstOrDefault();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> exp)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(exp);
        }

        public TEntity First(Expression<Func<TEntity, bool>> exp)
        {
            return _dbContext.Set<TEntity>().First(exp);
        }

        public TEntity Find(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> Find(IEnumerable<Guid> ids)
        {
            return _dbContext.Set<TEntity>().Where((TEntity e) => ids.Contains(e.Id)).ToList();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> exp)
        {
            return _dbContext.Set<TEntity>().Where(exp);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }

    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Caso> Caso { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

    }
}
