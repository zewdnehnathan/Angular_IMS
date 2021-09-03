using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Inventory.Application.Dto;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Facade;
using Inventory.Domain.Model;
using Inventory.Application.Interfaces;
using Inventory.Domain.Interfaces.Repository;
using Inventory.Application.Mapping;
using System.Linq.Expressions;
using System;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuancesController : ControllerBase
    {
        private readonly IService<IssuanceDto, IssuanceEntity> _issuanceService;
        private readonly IIssuanceRepository _issuanceRepository;
        public IssuancesController(IService<IssuanceDto, IssuanceEntity> issuanceService, IIssuanceRepository issuanceRepository)
        {
            _issuanceService = issuanceService;
            _issuanceRepository = issuanceRepository;
        }

        [HttpPost]
        public async Task<ResponseDto<IssuanceDto>> Create(IssuanceEntity issuance)
        {
            return await _issuanceService.AddIssuance(issuance);
        }

        [HttpGet]
        public async Task<ResponseDto<IssuanceDto>> GetAll()
        {
            return await _issuanceService.GetAllIssuance();
        }

        [HttpGet("GetIssuanceDetailById")]
        public async Task<ResponseDto<IssuanceDto>> GetAllIssuanceDetailInformation(int id)
        {
            Issuance x = await _issuanceRepository.GetAllIssuanceDetailInformation(id);
            return new ResponseDto<IssuanceDto>(IssuanceMapping.ToDto(x));
        }

        Expression<Func<Issuance, bool>> FindByIssuanceId(int id)
        {
            return x => x.Id == id;
        }

        //[HttpGet("GetIssuanceDetailByCriteria")]
        //public ResponseDto<IssuanceDto> GetIssuanceDetailByCriteria(int id)
        //{
        //    return _issuanceService.GetIssuanceByCriteria(FindByIssuanceId(id));
        //}

       /* [HttpDelete]
        public ResponseDto<IssuanceDto> Remove(int id)
        {
            return _issuanceService.DeleteIssuance(id);
        }

        [HttpPut]
        public ResponseDto<IssuanceDto> Update(IssuanceEntity entity)
        {
            return _issuanceService.UpdateIssuance(entity);
        }*/
    }
}
