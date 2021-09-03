using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Domain.Model;

namespace Inventory.Application.Dto
{
    public class IssuanceDto
    {
        public int Id { get; set; }

        public int RequestId { get; set; }

        public string IssuedBy { get; set; }

        public DateTime IssuedDate { get; set; }

        public List<ItemIssuance> ItemIssued { get; set; }
    }
}
