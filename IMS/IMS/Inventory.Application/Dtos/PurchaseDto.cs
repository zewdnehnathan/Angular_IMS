using Inventory.Domain;
using System;
using System.Collections.Generic;

namespace Inventory.Application.Dtos
{
    public class PurchaseDto
    {
        private List<Purchase> purchases;

        public PurchaseDto(List<Purchase> purchases)
        {
            this.purchases = purchases;
        }

        public int Id { get; set; }
        public DateTime RefDate { get; set; }
        public string Supplier { get; set; }
        public string InvoiceNo { get; set; }
        public string OtherRefNo { get; set; }
        public ICollection<PurchaseDt> PurchaseItems {get;set;}


    }
}
