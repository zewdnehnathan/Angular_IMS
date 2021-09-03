using Inventory.Domain.Entities;
using Inventory.Domain.Seed;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Repository
{
    public interface IPurchaseRepository : IAsyncRepository<Purchase>
    {
        Task<List<Purchase>> GetByUser(string user);
        Task<List<Purchase>> AddAsync(Purchase purchase);
        Task<List<PurchaseEntity>> AddAsync(PurchaseEntity purchase);
        bool Update(PurchaseEntity purchase);
        bool Delete(int Id);

        public Task<IEnumerable<Purchase>> GetWithPredicateAsync(Expression<Func<Purchase, Boolean>> predicate, int pageIndex, int pageSize);
    }
}
