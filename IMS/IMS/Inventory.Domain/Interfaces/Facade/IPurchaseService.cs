
using Inventory.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Facade
{
    public interface IPurchaseService
    {
        Task<List<Entities.PurchaseEntity>> Get(int? id);
        Task<Entities.PurchaseEntity> Add(PurchaseEntity purchase);
        Task<Entities.PurchaseEntity> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize);
        bool Update(PurchaseEntity purchase);
        bool Remove(int id);


    }
}
