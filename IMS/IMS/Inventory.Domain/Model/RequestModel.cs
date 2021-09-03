using Inventory.Domain.Model;
using Inventory.Domain.Seed;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ItemRequest.Domain.Model
{
    public class RequestModel : BaseAuditModel
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
       // public List<Item> Items { get; set; }
        public RequestModel()
        {

        }

        
    }
}