using Inventory.Application.Dto;
using Inventory.Application.Dtos;
using Inventory.Domain;
using Inventory.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IPurchaseService
    {
        Task<List<Purchase>> Get(int? id);
        Task<PurchaseEntity> Add(PurchaseEntity purchase);
        Task<List<PurchaseEntity>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize);
        bool Update(PurchaseEntity purchase);
        bool Remove(int id);


    }
}
