using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Repository
{
    public interface IItemRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        public bool Update(T _object);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public bool Delete(int id);
        public Task<IEnumerable<T>> GetWithPredicateAsync(Expression<Func<Item, Boolean>> predicate, int pageIndex, int pageSize);
    }
}
