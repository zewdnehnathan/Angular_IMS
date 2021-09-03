using Inventory.API.Authentication;
using Inventory.Application.Dto;
using Inventory.Application.Dtos;
using Inventory.Application.Interfaces;
using Inventory.Domain;
using Inventory.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class PurchaseController : ControllerBase
    {

        //private readonly IPurchaseServices _purchasesService;
        private readonly IPurchaseService _purchasesService;
        
        public PurchaseController(IPurchaseService membersService)
        {
            _purchasesService = membersService;           
        }
        [HttpGet]
        public Task<List<Purchase>> Get(int? id)
        {
            return  _purchasesService.Get(id);
        }
         
        [HttpGet("GetByPred")]
        public async Task<List<PurchaseEntity>> GetByPred(int? id, string searchKey, int? pageIndex, int? pageSize) 
        {
            return await _purchasesService.GetWithPredicate(id, searchKey, pageIndex, pageSize);
        }

        [HttpPost]
        public  Task<PurchaseEntity> Post(PurchaseEntity member)
        {
            return _purchasesService.Add(member);
        }
        [HttpPut]
        public bool Update(PurchaseEntity member)
        {
            return _purchasesService.Update(member);
        }
        [HttpDelete]
        public bool Remove(int id)
        {
            return _purchasesService.Remove(id);
        }

    }
}
