using Inventory.Application.Dto;
using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Mapping
{
    public static class IssuanceMapping
    {

        public static IssuanceDto ToDto(Issuance entity)
        {
            return new IssuanceDto
            {
                Id = entity.Id,
                RequestId = entity.RequestId,
                IssuedBy = entity.IssuedBy,
                IssuedDate = entity.IssuedDate
            };
        }
        public static Issuance ToEntity(this IssuanceDto dto)
        {
            return new Issuance
            {
                Id = dto.Id,
                IssuedBy = dto.IssuedBy,
                RequestId = dto.RequestId,
                IssuedDate = dto.IssuedDate,
                ItemIssued = dto.ItemIssued
            };
        }
    }
}
