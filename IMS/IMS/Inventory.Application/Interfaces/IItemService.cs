using Inventory.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IItemService
    {
        Task<GenericResponseDto<ItemDto>> Get(int? id);
        Task<GenericResponseDto<ItemDto>> GetAll();
        Task<GenericResponseDto<ItemDto>> Create(ItemDto item);
        GenericResponseDto<ItemDto> Update(ItemDto item);
        GenericResponseDto<ItemDto> Delete(int id);
        Task<GenericResponseDto<ItemDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize);
    }
}
