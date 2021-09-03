using Inventory.Domain.Interfaces.Repository;
using Inventory.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repository
{
    public class ItemRepository : IItemRepository<Item>
    {

        private readonly InventoryContext _dbContext;
        public ItemRepository(InventoryContext context)
        {
            _dbContext = context;
        }
        public async Task<Item> CreateAsync(Item _item)
        {
            var item = await _dbContext.Items.AddAsync(_item);
            _dbContext.SaveChanges();
            return item.Entity;
        }
        public bool Update(Item _item)
        {
            _dbContext.Update(_item);
            _dbContext.SaveChanges();
            return true;
        }
        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _dbContext.Items.ToListAsync();
        }
        public async Task<Item> GetByIdAsync(int id)
        {
            return await _dbContext.Items.FindAsync(id);
        }
        public bool Delete(int id)
        {
            _dbContext.Items.Remove(_dbContext.Items.Find(id));
            _dbContext.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Item>> GetWithPredicateAsync(Expression<Func<Item, Boolean>> predicate, int pageIndex, int pageSize)
        {
            return predicate == null ? (await _dbContext.Items.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync())
                : (await _dbContext.Items.Where(predicate).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync());
        }

    }
}
