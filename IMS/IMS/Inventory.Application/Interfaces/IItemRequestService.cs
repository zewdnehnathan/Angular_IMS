using Inventory.Application.Dtos;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IItemRequestService
    {
        Task<GenericResponseDto<RequestItemDto>> Get(int? id);
        Task<GenericResponseDto<RequestItemDto>> GetAll();
        Task<GenericResponseDto<RequestItemDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize);
        Task<GenericResponseDto<RequestItemDto>> Create(RequestItemDto request);
        GenericResponseDto<RequestItemDto> Update(RequestItemDto request);
        GenericResponseDto<RequestItemDto> Delete(int id);
    }
}
