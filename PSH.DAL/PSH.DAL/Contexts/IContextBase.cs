using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace PSH.DAL.Contexts
{
    public interface IContextBase : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
        int SaveChanges();
        DbEntityEntry<T> Entry<T>(T entity) where T : class;

    }
}
