using Inventory.Domain.Seed;
using System;

namespace Inventory.Domain.Entities
{
    public class PurchaseDtEntity: BaseEntity<PurchaseDt>
    {

        public int Id { get; set; }
        public int? Purchaseid { get; set; }
        public string StoreCode { get; set; }
        public string ItemCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string CrtBy { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtWs { get; set; }
        public string LmBy { get; set; }
        public DateTime? LmDt { get; set; }
        public string LmWs { get; set; }


        public override PurchaseDt MapToModel()
        {
            throw new NotImplementedException();
        }

        public override PurchaseDt MapToModel(PurchaseDt t)
        {
            throw new NotImplementedException();
        }
    }
}
