using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Guid InstanceId { get; }

        void Delete(TEntity entity);

        void Delete(params object[] keyValues);

        TEntity Find(params object[] keyValues);

        Task<TEntity> FindAsync(params object[] keyValues);

        Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues);

        IDataContext GetContext();

        TEntity Insert(TEntity entity);

        void InsertGraph(TEntity entity);

        void InsertGraphRange(IEnumerable<TEntity> entities);

        void InsertRange(IEnumerable<TEntity> entities);

        IRepositoryQuery<TEntity> Query();

        IQueryable<TEntity> QueryGet(Expression<Func<TEntity, bool>> filter);

        IQueryable<TEntity> QueryGet();

        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);

        void Update(TEntity entity);
    }
}