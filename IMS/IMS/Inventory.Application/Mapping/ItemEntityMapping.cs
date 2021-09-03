using Inventory.Application.Dtos;
using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Mapping
{
    public static class ItemEntityMapping
    {
        public static ItemDto ToDto(this Item entity)
        {
            return new ItemDto
            {
                Id = entity.Id,
                Name = entity.Name,
                SerialNumber = entity.SerialNumber,
                Category = entity.Category,
                UnitOfMeasurement = entity.UnitOfMeasurement,
                Description = entity.Description,
            };
        }
        public static Item ToEntity(this ItemDto dto)
        {
            return new Item
            {
                Id = dto.Id,
                Name = dto.Name,
                SerialNumber = dto.SerialNumber,
                Category = dto.Category,
                UnitOfMeasurement = dto.UnitOfMeasurement,
                Description = dto.Description,
            };
        }
    }
}
