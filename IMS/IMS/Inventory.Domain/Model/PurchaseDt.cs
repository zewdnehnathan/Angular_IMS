using Inventory.Domain.Seed;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Inventory.Domain
{
    public  class PurchaseDt : BaseAuditModel
    {
        public int Id { get; set; }
        public int? Purchaseid { get; set; }
        public string StoreCode { get; set; }
        public string ItemCode { get; set; }
       
        public decimal? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        

    }
}
