using ItemRequest.Domain.Model;
using ItemRequest.Domain.Seeds;
using ItemRequest.Domain.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ItemRequest.Domain.Entities
{
   public class RequestEntity : BaseEntity<RequestModel>
    {
        public int Quantity { get; set; }
        public string Status { get; set; }
        public List<ItemViewModel> Items { get; set; }

        public RequestEntity()
        {
            Items = new List<ItemViewModel>();
        }

        public RequestEntity(RequestModel requestModel)
        {
            Quantity = requestModel.Qunatity;
            Status = requestModel.Status;
            Items = requestModel.Items?.Select(x => new ItemViewModel(x)).ToList();
        }

        public override RequestModel MapToModel()
        {
            RequestModel requestModel = new RequestModel();
            requestModel.Qunatity = Quantity;
            requestModel.Status = Status;
            requestModel.Items = Items?.Select(x => x.MapToModel()).ToList();
            return requestModel;
        }

        public override RequestModel MapToModel(RequestModel t)
        {
            throw new NotImplementedException();
        }
    }

   
    
   
}
