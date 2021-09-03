using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Domain.Seed;

namespace Inventory.Domain.Model
{
    public class Issuance : BaseAuditModel
    {
        public int RequestId { get; set; }

        public string IssuedBy { get; set; }

        public DateTime IssuedDate { get; set; }

        public List<ItemIssuance> ItemIssued { get; set; }

        public Issuance()
        {
            this.RequestId = RequestId;
            this.IssuedBy = IssuedBy;
            this.IssuedDate = IssuedDate;
            this.ItemIssued = ItemIssued;
        }
    }
}
