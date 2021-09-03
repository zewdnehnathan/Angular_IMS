using System;
namespace Inventory.Domain.Seed
{
    public abstract class BaseEntity<T> where T : BaseAuditModel
    {
        public int Id { get; protected set; }
        public string CreatedBy { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public string CreatedWorkStation { get; protected set; }
        public string ModifiedBy { get;  set; }
        public DateTime ModifiedDate { get;  set; }
        public string ModifiedWorkStation { get;  set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);
    }
}
