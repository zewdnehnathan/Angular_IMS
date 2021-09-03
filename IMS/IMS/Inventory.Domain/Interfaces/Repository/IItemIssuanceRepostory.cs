using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Entities;
using Inventory.Domain.Seed;
using Inventory.Domain.Model;
namespace Inventory.Domain.Interfaces.Repository
{
    public interface IItemIssuanceRepostory : IAsyncRepository<ItemIssuance>
    {
        Task<List<Model.ItemIssuance>>  GetByIssuance(Guid issuance);
    }
}
