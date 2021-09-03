using ItemRequest.Domain.Seeds;
using ItemRequest.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequest.Domain.Model
{
    public class RequestModel:BaseModelEntity
    {
        public int Qunatity { get; set; }
        public string Status { get; set; }
        public List<ItemViewModel> Items { get; set; }
        public RequestModel()
        {

        }
    }
}
