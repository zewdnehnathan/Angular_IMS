using Inventory.Domain;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repository
{
    public class PurchaseRepository : AsyncRepository<Purchase>, IPurchaseRepository
    {
        private readonly InventoryContext _purchaseContext;

        public PurchaseRepository(InventoryContext purchaseContext) : base(purchaseContext)
        {
            _purchaseContext = purchaseContext;
        }
        public async Task<List<Purchase>> AddAsync(Purchase purchase)
        {
            var member = await _purchaseContext.Purchases.AddAsync(purchase);
            _purchaseContext.SaveChanges();
            List<Purchase> retrnee = new List<Purchase>(); 
            return retrnee;
        }

        public async Task<PurchaseEntity> AddAsync(PurchaseEntity purchase)
        {
            var member = await _purchaseContext.Purchases.AddAsync(purchase.MapToModel());
            _purchaseContext.SaveChanges();
            PurchaseEntity retrnee = new PurchaseEntity();
            return retrnee;
        }

        public bool Delete(int id)
        {
            _purchaseContext.PurchaseDts.Remove(_purchaseContext.PurchaseDts.Find(id));
            _purchaseContext.Purchases.Remove(_purchaseContext.Purchases.Find(id));
            _purchaseContext.SaveChanges();
            return true;
        }

        public override async Task<IReadOnlyList<Purchase>> GetAllAsync()
        {
            var purchases = _purchaseContext.Purchases.Include(purchase => purchase.PurchaseDts).ToListAsync();
            return await purchases;
        }

        public async Task<List<Purchase>> GetByUser(string user)
        {
            var purchaseList = (await GetAsync(x => x.CreatedBy == user)).ToList();
            return purchaseList;
        }

        public async Task<IEnumerable<Purchase>> GetWithPredicateAsync(Expression<Func<Purchase, bool>> predicate, int pageIndex, int pageSize)
        {
            return predicate == null ? (await _purchaseContext.Purchases.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync())
               : (await _purchaseContext.Purchases.Where(predicate).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync());
        }

        public bool Update(PurchaseEntity purchase)
        {
            _purchaseContext.Update(purchase.MapToModel());
            _purchaseContext.SaveChanges();
            return true;
        }
    }
}
