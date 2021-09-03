using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Domain.Seed
{
    public interface IAsyncRepository<T> where T : BaseAuditModel
    {
        Task<T> AddAsync(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryAsync(Expression<Func<T, bool>> predicate);

    }
}
