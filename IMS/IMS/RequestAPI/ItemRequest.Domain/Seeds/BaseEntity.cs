using DocumentFormat.OpenXml.Office.CustomUI;
using ItemRequest.Domain.ViewModel;
using System;
using System.Collections.Generic;

namespace ItemRequest.Domain.Seeds
{
    public abstract class BaseEntity<T> where T : BaseModelEntity
    {
        public Guid Id { get; protected set; }
        public bool IsActive { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
        public abstract T MapToModel();
        public abstract T MapToModel(T t);



    }
}
