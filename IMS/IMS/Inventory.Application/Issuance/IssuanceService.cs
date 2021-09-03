using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Inventory.Domain.Entities;
using Inventory.Domain.Model;
using Inventory.Domain.Interfaces.Facade;
using Inventory.Domain.Interfaces.Repository;
using Inventory.Application.Dto;
using Inventory.Application.Mapping;
using Inventory.Application.Interfaces;

namespace Inventory.Application
{
    public class IssuanceService : IService<IssuanceDto, IssuanceEntity>
    {
        private readonly IIssuanceRepository _issuanceRepository;
        public IssuanceService(IIssuanceRepository issuanceRepository)
        {
            _issuanceRepository = issuanceRepository;
        }

        public async Task<ResponseDto<IssuanceDto>> AddIssuance(IssuanceEntity issuanceEntity)
        {
            Issuance issuance = await _issuanceRepository.AddAsync(issuanceEntity.MapToModel());
            return new ResponseDto<IssuanceDto>(IssuanceMapping.ToDto(issuance), true, "Item is issued to the employee");
        }

        public async Task<ResponseDto<IssuanceDto>> GetAllIssuance()
        {
            var objInssuanceList = await _issuanceRepository.GetAllAsync();
            List<IssuanceDto> issuanceList = objInssuanceList.Select(x => IssuanceMapping.ToDto(x)).ToList();
            return new ResponseDto<IssuanceDto>(issuanceList);
        }

        //public ResponseDto<IssuanceDto> GetIssuanceByCriteria(Expression<Func<Issuance, bool>> filter)
        //{
        //    var objInssuanceList =  _issuanceRepository.GetAsyncListByCriteria(filter);
        //    List<IssuanceDto> issuanceList = objInssuanceList.Select(x => IssuanceMapping.ToDto(x)).ToList();
        //    return new ResponseDto<IssuanceDto>(issuanceList);
        //}

        public bool DeleteIssuance(int id)
        {
            return _issuanceRepository.Delete(id);
        }


        public bool UpdateIssuance(IssuanceEntity issuance)
        {
            Issuance issuanceModel = issuance.MapToModel();
            return _issuanceRepository.Update(issuanceModel);
        }
    }
}
