using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemRequest.Domain.Seeds
{
    public class BaseModelEntity
    {
        public Guid Guid { get; protected set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUser { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
