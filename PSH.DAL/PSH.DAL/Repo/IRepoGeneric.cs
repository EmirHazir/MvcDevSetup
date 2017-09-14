using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PHS.Lib.Models;

namespace PSH.DAL.Repo
{
    public interface IRepoGeneric<TEntity> where TEntity : ModelBase
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetById(Guid id);
        Task<TEntity> GetByIDAsync(Guid id);
        void Insert(TEntity entity);
        bool IsExistsById(Guid id);
        Task<bool> IsExistsByIdAsync(Guid id);
        void Update(TEntity entityToUpdate);
    }
}