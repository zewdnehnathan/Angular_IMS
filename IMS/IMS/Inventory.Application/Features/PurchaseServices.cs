using Inventory.Application.Dto;
using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Inventory.Domain;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repository;
using LinqKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Application.Features
{
    public class PurchaseServices : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseServices(IPurchaseRepository purchaseRepository) 
        {
            _purchaseRepository = purchaseRepository;
        }

        public async Task<List<Purchase>> Add(Purchase purchase)
        {
            return await _purchaseRepository.AddAsync(purchase);
        }

        public async Task<List<Purchase>> Get(int? id)
        {
            return (await _purchaseRepository.GetAllAsync()).ToList();
        }

        public bool Remove(int id)
        {
            _purchaseRepository.Delete(id);
            return true;
        }

        public bool Update(PurchaseEntity purchase)
        {
            _purchaseRepository.Update(purchase);
            return true;
        }


        public async Task<PurchaseDto> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize)
        {
            var predicate = PredicateBuilder.True<Purchase>();
            if (id != null)
                predicate = predicate.And(p => p.Id == id);
            else
                predicate = string.IsNullOrEmpty(searchKey) ? null
                           : predicate.And
                            (
                                p => p.Supplier.Contains(searchKey) ||
                                p.OtherRefNo.Contains(searchKey) ||
                                p.InvoiceNo.Contains(searchKey)
                            );
            return new PurchaseDto
                (
                    (await _purchaseRepository.GetWithPredicateAsync(predicate, pageIndex ?? 0, pageSize ?? 2)).ToList()
                  
                );
        }

        public Task<PurchaseEntity> Add(PurchaseEntity purchase)
        {
            throw new System.NotImplementedException();
        }

        Task<List<PurchaseEntity>> IPurchaseService.GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize)
        {
            throw new System.NotImplementedException();
        }
    }
}
