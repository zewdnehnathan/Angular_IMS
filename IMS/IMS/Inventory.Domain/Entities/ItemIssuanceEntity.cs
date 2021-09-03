using System;
using Inventory.Domain.Model;
using Inventory.Domain.Seed;

namespace Inventory.Domain.Entities
{
    public class ItemIssuanceEntity : BaseEntity<ItemIssuance>
    {
        public int ItemId { get; set; }

        public int IssuanceId { get; set; }

        public int StoreId { get; set; }

        public decimal Quantity { get; set; }

        public ItemIssuanceEntity()
        {

        }

        public ItemIssuanceEntity(ItemIssuance objItemIssuance)
        {
            IssuanceId = objItemIssuance.IssuanceId;
            ItemId = objItemIssuance.ItemId;
            StoreId = objItemIssuance.StoreId;
            Quantity = objItemIssuance.Quantity;
        }

        public override ItemIssuance MapToModel()
        {
            ItemIssuance objItemIssuance = new ItemIssuance(ItemId,IssuanceId,StoreId,Quantity);
            objItemIssuance.IssuanceId = IssuanceId;
            objItemIssuance.ItemId = ItemId;
            objItemIssuance.StoreId = StoreId;
            objItemIssuance.Quantity = Quantity;
            return objItemIssuance;
        }

        public override ItemIssuance MapToModel(ItemIssuance objItemIssuance)
        {
            objItemIssuance.IssuanceId = IssuanceId;
            objItemIssuance.ItemId = ItemId;
            objItemIssuance.StoreId = StoreId;
            objItemIssuance.Quantity = Quantity;
            return objItemIssuance;
        }
    }
}
