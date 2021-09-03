using Inventory.Domain;
using Inventory.Domain.Model;
using ItemRequest.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Application.Interfaces
{
    public interface IInventoryContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<RequestModel> request { get; set; }
        public DbSet<PurchaseDt> PurchaseDts { get; set; }

    }
}
