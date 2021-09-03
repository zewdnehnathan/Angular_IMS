using System;

namespace Inventory.Domain.Seed
{
    public class BaseAuditModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedWorkstation { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedWorkstation { get; set; }
    }
}
