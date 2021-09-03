using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Domain.Seed;
using Inventory.Domain.Model;

namespace Inventory.Domain.Entities
{
    public class IssuanceEntity : BaseEntity<Issuance>
    {
        public int Id { get; set; }

        public int RequestId { get; set; }

        public string Issurer { get; set; }

        public DateTime IssuedDate { get; set; }

        public List<ItemIssuanceEntity> ItemIssuance { get; set; }

        public IssuanceEntity()
        {
            ItemIssuance = new List<ItemIssuanceEntity>();
        }

        public IssuanceEntity(Domain.Model.Issuance objIssuanceModel)
        {
            this.Id = objIssuanceModel.Id;
            this.Issurer = objIssuanceModel.IssuedBy;
            this.ItemIssuance = objIssuanceModel.ItemIssued.Select(x => new ItemIssuanceEntity(x)).ToList();
            this.IssuedDate = objIssuanceModel.IssuedDate;
            this.RequestId = objIssuanceModel.RequestId;
        }

        public override Issuance MapToModel()
        {
            Domain.Model.Issuance objIssuanceModel = new Domain.Model.Issuance();
            objIssuanceModel.Id = Id;
            objIssuanceModel.IssuedBy = Issurer;
            objIssuanceModel.ItemIssued = ItemIssuance?.Select(x => x.MapToModel()).ToList();
            objIssuanceModel.IssuedDate = IssuedDate;
            objIssuanceModel.RequestId = RequestId;
            return objIssuanceModel;
        }

        public override Issuance MapToModel(Model.Issuance objIssuanceModel)
        {
            objIssuanceModel.Id = Id;
            objIssuanceModel.IssuedBy = Issurer;
            objIssuanceModel.IssuedDate = IssuedDate;
            objIssuanceModel.RequestId = RequestId;
            objIssuanceModel.ItemIssued = ItemIssuance?.Select(x => x.MapToModel()).ToList();
            return objIssuanceModel;
        }
    }
}
