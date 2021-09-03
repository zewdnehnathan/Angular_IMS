using ItemRequest.Domain.Model;
using ItemRequest.Domain.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequest.Domain.ViewModel
{
    public  class ItemViewModel: BaseEntity<RequestModel>
    {
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public decimal Qty { get; protected set; }
        public decimal UnitPrice { get; protected set; }

        public ItemViewModel(ItemViewModel x)
        {
            Name = x.Name;
            Category = x.Category;
            Qty = x.Qty;
            UnitPrice = x.UnitPrice;
        }
       
    }
}
