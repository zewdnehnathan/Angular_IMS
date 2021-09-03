using System;
using System.Collections.Generic;
using Inventory.Domain.Seed;
using System.Threading.Tasks;
using Inventory.Domain.Model;
using System.Linq.Expressions;
using System.Linq;

namespace Inventory.Domain.Interfaces.Repository
{
    public interface IIssuanceRepository 
    {
        Task<Issuance> AddAsync(Issuance entity);

        bool Update(Issuance entity);

        bool Delete(int id);

        Task<IReadOnlyList<Issuance>> GetAllAsync();

        //public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        //
        IQueryable<Issuance> GetAsyncListByCriteria(Expression<Func<Issuance, bool>> predicate);

        Task<Issuance> GetAllIssuanceDetailInformation(int id);
    }
}
