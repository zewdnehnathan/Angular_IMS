using Inventory.Application.Dtos;
using Inventory.Domain.Entities;
using ItemRequest.Domain.Model;
using System.Linq;

namespace Inventory.Application.Mapping
{
    public static class RequestEntityMapping
    {

        public static RequestItemDto ToDto(this RequestModel entity)
        {
            return new RequestItemDto
            {
                Id = entity.Id,
                Status = entity.Status,
                Quantity = entity.Quantity,
                //Items = entity.Items?.Select(x => new ItemEntity(x)).ToList(),

        };
        }
        public static RequestModel ToEntity(this RequestItemDto dto)
        {
            return new RequestModel
            {
                Id = dto.Id,
                Status = dto.Status,
                Quantity = dto.Quantity,
               
            };
        }
    }
}
