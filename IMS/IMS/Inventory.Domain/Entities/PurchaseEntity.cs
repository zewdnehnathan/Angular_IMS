using Inventory.Domain.Seed;
using System;
using System.Collections.Generic;

namespace Inventory.Domain.Entities
{
    public class PurchaseEntity : BaseEntity<Purchase>
    {

        
        public int Id { get; set; }
        public DateTime RefDate { get; set; }
        public string Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public string OtherRefNo { get; set; }
      

        public virtual ICollection<PurchaseDt> PurchaseDts { get; set; }


        public PurchaseEntity()
        {
            PurchaseDts = new HashSet<PurchaseDt>();
        }
        public PurchaseEntity(Purchase purchase)
        {
            Id = purchase.Id;
            InvoiceNo = purchase.InvoiceNo;
            OtherRefNo = purchase.OtherRefNo;
            PurchaseDts = purchase.PurchaseDts;
            RefDate = purchase.RefDate;
            Supplier = purchase.Supplier;
            
        }

        public override Purchase MapToModel(Purchase t)
        {
            Purchase purchase = new Purchase();
            purchase.Id = t.Id;
            purchase.InvoiceNo = t.InvoiceNo;
            purchase.ModifiedBy = t.ModifiedBy;
            purchase.ModifiedDate = t.ModifiedDate;
            purchase.ModifiedWorkstation = t.ModifiedWorkstation;
            purchase.OtherRefNo = t.OtherRefNo;
            purchase.PurchaseDts = t.PurchaseDts;
            purchase.RefDate = t.RefDate;
            purchase.Supplier = t.Supplier;

            return purchase;
        }

        public override Purchase MapToModel()
        {
              Purchase purchase = new Purchase();
            purchase.Id = Id;
            purchase.InvoiceNo = InvoiceNo;
            purchase.ModifiedBy =ModifiedBy;
            purchase.ModifiedDate = ModifiedDate;
            purchase.ModifiedWorkstation = ModifiedWorkStation;
            purchase.OtherRefNo =OtherRefNo;
            purchase.PurchaseDts = PurchaseDts;
            purchase.RefDate = RefDate;
            purchase.Supplier = Supplier;

            return purchase;
        }
    }
}
