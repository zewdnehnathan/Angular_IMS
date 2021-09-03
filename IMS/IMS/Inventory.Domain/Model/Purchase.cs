using Inventory.Domain.Entities;
using Inventory.Domain.Seed;
using System;
using System.Collections.Generic;

#nullable disable

namespace Inventory.Domain
{
    public  class Purchase : BaseAuditModel
    {
        public int Id { get; set; }
        public DateTime RefDate { get; set; }
        public string Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public string OtherRefNo { get; set; }
        

        public virtual ICollection<PurchaseDt> PurchaseDts { get; set; }

        public PurchaseEntity MapToEntity<T>()
        {
            PurchaseEntity purchase = new PurchaseEntity();
            purchase.Id = Id;
            purchase.InvoiceNo = InvoiceNo;
            purchase.ModifiedBy = ModifiedBy;
            purchase.ModifiedDate = ModifiedDate;
            purchase.ModifiedWorkStation = ModifiedWorkstation;
            purchase.OtherRefNo = OtherRefNo;
            purchase.PurchaseDts = PurchaseDts;
            purchase.RefDate = RefDate;
            purchase.Supplier = Supplier;

            return  purchase;
        }
    }
}
