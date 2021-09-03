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
    public class IssuanceRepository : IIssuanceRepository
    {
        private readonly InventoryContext _context;
        public IssuanceRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<Issuance> AddAsync(Issuance entity)
        {
            await _context.Issuance.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public bool Delete(int id)
        {
            _context.Set<Issuance>().Remove(_context.Issuance.Find(id));
            _context.SaveChangesAsync();
            return true;
        }

        public async Task<IReadOnlyList<Issuance>> GetAllAsync()
        {
            return await _context.Issuance.Include(x => x.ItemIssued).ToListAsync();
        }

        public async Task<Issuance> GetByIdAsync(int id)
        {
            return await _context.Issuance.FindAsync(id);
        }

        public bool Update(Issuance entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Update(entity);
            _context.SaveChanges();
            return true;
        }

        public async Task<Issuance> GetAllIssuanceDetailInformation(int id)
        {
            return await _context.Issuance.Where(x => x.Id == id).Include(x => x.ItemIssued).FirstOrDefaultAsync();
        }

        public IQueryable<Issuance> GetAsyncListByCriteria(Expression<Func<Issuance, bool>> predicate)
        {
            return _context.Issuance.Include(x => x.ItemIssued).Where(predicate);
        }

        public async Task<Issuance> GetByRequest(int id)
        {
            return await _context.Issuance.Where(x => x.Id == id).Include(x => x.ItemIssued).FirstOrDefaultAsync();
        }
    }
}
