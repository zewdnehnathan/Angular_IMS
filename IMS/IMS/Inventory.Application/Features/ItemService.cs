using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Inventory.Application.Mapping;
using Inventory.Domain.Interfaces.Repository;
using Inventory.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqKit;

namespace Inventory.Application.Features
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository<Item> _itemRepository;

        public ItemService(IItemRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<GenericResponseDto<ItemDto>> Create(ItemDto item)
        {
            return new GenericResponseDto<ItemDto>((await _itemRepository.CreateAsync(item.ToEntity())).ToDto(), true, "Item Created Successfully");
        }

        public async Task<GenericResponseDto<ItemDto>> Get(int? id)
        {
            return new GenericResponseDto<ItemDto>((await _itemRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public GenericResponseDto<ItemDto> Remove(int id)
        {
            return new GenericResponseDto<ItemDto>(_itemRepository.Delete(id), "Item Deleted Successfully");
        }

        public GenericResponseDto<ItemDto> Update(ItemDto item)
        {
            return new GenericResponseDto<ItemDto>(item, _itemRepository.Update(item.ToEntity()), "Item Updated Successfully");

        }
        public async Task<GenericResponseDto<ItemDto>> GetById(int? id)
        {
            return new GenericResponseDto<ItemDto>((await _itemRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public async Task<GenericResponseDto<ItemDto>> GetAll()
        {
            return new GenericResponseDto<ItemDto>((await _itemRepository.GetAllAsync()).Select(x => x.ToDto()).ToList());
        }

        public GenericResponseDto<ItemDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponseDto<ItemDto>> GetWithPredicate(int? id, string searchKey, int? pageIndex, int? pageSize)
        {
            var predicate = PredicateBuilder.True<Item>();
            if (id != null)
                predicate = predicate.And(p => p.Id == id);
            else
                predicate = string.IsNullOrEmpty(searchKey) ? null
                           : predicate.And
                            (
                                p => p.Name.Contains(searchKey) ||
                                p.Description.Contains(searchKey)
                            );
            return new GenericResponseDto<ItemDto>
                (
                    (await _itemRepository.GetWithPredicateAsync(predicate, pageIndex ?? 0, pageSize ?? 2))
                    .Select(x => x.ToDto()
                    ).ToList()
                );
        }

    }
}
