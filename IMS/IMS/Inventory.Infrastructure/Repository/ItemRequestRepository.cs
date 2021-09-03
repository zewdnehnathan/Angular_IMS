using Inventory.Domain.Interfaces.Repository;
using ItemRequest.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repository
{
    public class ItemRequestRepository : IRequestItemRepository<RequestModel>
    {
        private readonly InventoryContext _dbContext;
        public ItemRequestRepository(InventoryContext requestContext)
        {
            _dbContext = requestContext;
        }



        public async Task<RequestModel> CreateAsync(RequestModel _request)
        {
            var request = await _dbContext.request.AddAsync(_request);
            _dbContext.SaveChanges();
            return request.Entity;
        }
        public bool Update(RequestModel _request)
        {
            _dbContext.Update(_request);
            _dbContext.SaveChanges();
            return true;
        }
        public async Task<IEnumerable<RequestModel>> GetAllAsync()
        {
            return await _dbContext.request.ToListAsync();
        }
        public async Task<IEnumerable<RequestModel>> GetWithPredicateAsync(Expression<Func<RequestModel, Boolean>> predicate, int pageIndex, int pageSize)
        {
            return predicate == null ? (await _dbContext.request.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync())
                : (await _dbContext.request.Where(predicate).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync());
        }
        public async Task<RequestModel> GetByIdAsync(int id)
        {
            return await _dbContext.request.FindAsync(id);
        }
        public bool Delete(int id)
        {
            _dbContext.request.Remove(_dbContext.request.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

    }
}
