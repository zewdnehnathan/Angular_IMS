using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Domain.Seed;

namespace Inventory.Domain.Model
{
    public class ItemIssuance : BaseAuditModel
    {
        public int ItemId { get; set; }

        public int IssuanceId { get; set; }

       public int StoreId { get; set; }

        public decimal Quantity { get; set; }

        public ItemIssuance(int itemId, int issuedId, int StoreId, decimal quantity)
        {
            this.ItemId = itemId;
            this.IssuanceId = issuedId;
            this.StoreId = StoreId;
            this.Quantity = quantity;

        }
        public ItemIssuance()
        {
            this.ItemId = ItemId;
            this.IssuanceId = IssuanceId;
            this.StoreId = StoreId;
            this.Quantity = Quantity;

        }
    }
}
