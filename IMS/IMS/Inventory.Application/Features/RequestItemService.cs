using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Inventory.Application.Mapping;
using Inventory.Domain.Interfaces.Repository;
using ItemRequest.Domain.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Application.Features
{
    public class RequestItemService : IItemRequestService
    {
        private readonly IRequestItemRepository<RequestModel> _requestRepository;

        public RequestItemService(IRequestItemRepository<RequestModel> requestRepository)
        {
            _requestRepository = requestRepository;
        }
        public async Task<GenericResponseDto<RequestItemDto>> Create(RequestItemDto request)
        {
            return new GenericResponseDto<RequestItemDto>((await _requestRepository.CreateAsync(request.ToEntity())).ToDto(), true, "Member Created Successfully");
        }

        public async Task<GenericResponseDto<RequestItemDto>> Get(int? id)
        {
            return new GenericResponseDto<RequestItemDto>((await _requestRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public  GenericResponseDto<RequestItemDto> Remove(int id)
        {
            return new GenericResponseDto<RequestItemDto>(_requestRepository.Delete(id), "Member Deleted Successfully");
        }

        public  GenericResponseDto<RequestItemDto> Update(RequestItemDto request)
        {
            return new GenericResponseDto<RequestItemDto>(request, _requestRepository.Update(request.ToEntity()), "Member Updated Successfully");

        }
        public async Task<GenericResponseDto<RequestItemDto>> GetById(int? id)
        {
            return new GenericResponseDto<RequestItemDto>((await _requestRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public async Task<GenericResponseDto<RequestItemDto>> GetAll()
        {
            return new GenericResponseDto<RequestItemDto>((await _requestRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public GenericResponseDto<RequestItemDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto<RequestItemDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize)
        {
            throw new NotImplementedException();
        }

        
    }




}

