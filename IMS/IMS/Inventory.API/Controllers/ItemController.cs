using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<GenericResponseDto<ItemDto>> Get(int? id, string searchKey, int? pageindex, int? pageSize)
        {
            return await _itemService.GetWithPredicate(id, searchKey, pageindex, pageSize);
        }

        //[HttpGet]
        //public Task<GenericResponseDto<ItemDto>> Get(int? id)
        //{
        //    return _itemService.Get(id);
        //}

        [HttpPost]
        public async Task<GenericResponseDto<ItemDto>> Add(ItemDto item)
        {
            return await _itemService.Create(item);
        }
        [HttpPut]
        public GenericResponseDto<ItemDto> Edit(ItemDto item)
        {
            return _itemService.Update(item);
        }
        [HttpDelete]
        public GenericResponseDto<ItemDto> Remove(int id)
        {
            return _itemService.Delete(id);
        }
    }
}
