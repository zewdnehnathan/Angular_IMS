using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestItemController : ControllerBase
    {

        private readonly IItemRequestService _requestService;

        public RequestItemController(IItemRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet]
        public Task<GenericResponseDto<RequestItemDto>> Get()
        {
            return _requestService.GetAll();
        }
        [HttpGet("GetById")]
        public Task<GenericResponseDto<RequestItemDto>> Get(int? id)
        {
            return _requestService.Get(id);
        }

        [HttpGet("Getwithpredicate")]
        [Authorize]
        public async Task<GenericResponseDto<RequestItemDto>> Get(int? id, string searchKey, int? pageindex, int? pageSize)
        {
            return await _requestService.GetWithPredicate(id, searchKey, pageindex, pageSize);

        }

        [HttpPost("Create")]
        public async Task<GenericResponseDto<RequestItemDto>> Add(RequestItemDto request)
        {
            return await _requestService.Create(request);
        }
        [HttpPut("UPdate")]
        public GenericResponseDto<RequestItemDto> Edit(RequestItemDto request)
        {
            return _requestService.Update(request);
        }
        [HttpDelete("Delete")]
        public GenericResponseDto<RequestItemDto> Remove(int id)
        {
            return _requestService.Delete(id);
        }


    }
}
