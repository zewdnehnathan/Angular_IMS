using Inventory.Domain;
using Inventory.Domain.Model;
using ItemRequest.Domain.Model;
using Microsoft.EntityFrameworkCore;
using TestApp.Infrastructure;

#nullable disable

namespace Inventory.Infrastructure
{
    public partial class InventoryContext : DbContext, IInventoryContext
    {
        public InventoryContext()
        {

        }

        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<RequestModel> request { get; set; }
        public virtual DbSet<PurchaseDt> PurchaseDts { get; set; }
        public virtual DbSet<Issuance> Issuance { get; set; }
        public virtual DbSet<ItemIssuance> ItemIssuance { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
       
    }
}
