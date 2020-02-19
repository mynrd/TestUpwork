using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryQuery<TEntity> where TEntity : EntityBase
    {
        RepositoryQuery<TEntity> Filter(Expression<Func<TEntity, bool>> filter);

        IQueryable<TEntity> Get();

        Task<IEnumerable<TEntity>> GetAsync();

        IQueryable<IGrouping<TKey, TEntity>> GetGroupBy<TKey>(Expression<Func<TEntity, TKey>> keySelector);

        IQueryable<IGrouping<TKey, TEntity>> GetGroupByPage<TKey>(Expression<Func<TEntity, TKey>> keySelector, int page, int pageSize, out int totalCount);

        IEnumerable<TEntity> GetPage(int page, int pageSize, out int totalCount);

        RepositoryQuery<TEntity> Include(Expression<Func<TEntity, object>> expression);

        RepositoryQuery<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);

        IQueryable<TEntity> Select();

        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector);

        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
    }
}