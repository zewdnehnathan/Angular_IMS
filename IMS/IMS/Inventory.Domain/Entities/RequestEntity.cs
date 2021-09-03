using Inventory.Domain.Seed;
using ItemRequest.Domain.Model;

namespace ItemRequest.Domain.Entities
{
    public class RequestEntity : BaseEntity<RequestModel>
    {
        public int Quantity { get; set; }
        public string Status { get; set; }
        

        public RequestEntity(RequestModel requestModel)
        {
            Quantity = requestModel.Quantity;
            Status = requestModel.Status;
        }

        public override RequestModel MapToModel()
        {
            RequestModel requestModel = new RequestModel();
            requestModel.Quantity = Quantity;
            requestModel.Status = Status;
            return requestModel;
        }

        public override RequestModel MapToModel(RequestModel t)
        {
            throw new System.NotImplementedException();
        }
    }




}