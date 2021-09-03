using Inventory.Domain;
using Inventory.Domain.Entities;
using System.Collections.Generic;

namespace Inventory.Application.Dto
{
    public class ResponseDto<T>
    {
        private List<Purchase> purchases;
        private PurchaseEntity purchase;
        private List<PurchaseEntity> purchaseEntities;
        private List<IssuanceDto> issuanceList;
        private IssuanceDto issuanceDto;

        public List<Purchase> Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public ResponseDto(List<T> data, bool isSuccess, string message)
        {
            Data = null ;
            IsSuccess = isSuccess;
            Message = message;
        }
        public ResponseDto(T data, bool isSuccess, string message)
        {
            Data = null;
            IsSuccess = isSuccess;
            Message = message;
        }
        public ResponseDto(List<T> data, string message)
        {
            Data = null;
            IsSuccess = false;
            Message = message;
        }
        public ResponseDto(List<Purchase> purchases, List<T> data)
        {
            Data = null;
            IsSuccess = true;
        }
        public ResponseDto(List<Purchase> purchases, T data)
        {
            Data = null;
            IsSuccess = true;
        }
        public ResponseDto(bool isSuccess, string message)
        {
            Data = null;
            IsSuccess = isSuccess;
            Message = message;
        }

        public ResponseDto(List<PurchaseEntity> purchases,char c)
        {
            Data = null;
            IsSuccess = true;
            Message = "Well Done !";
        }

        public ResponseDto(List<Purchase> purchases)
        {
            this.purchases = purchases;
            Data = purchases;
            IsSuccess = true;
            Message = "Awssome !";
        }
        public ResponseDto(PurchaseEntity purchases)
        {
            this.purchase = purchases;
            IsSuccess = true;
            Message = "Awssome !";
        }

        public ResponseDto(List<PurchaseEntity> purchaseEntities)
        {
            this.purchaseEntities = purchaseEntities;
            IsSuccess = true;
            Message = "Amazing";
        }

        public ResponseDto(List<IssuanceDto> issuanceList)
        {
            this.issuanceList = issuanceList;
        }

        public ResponseDto(IssuanceDto issuanceDto)
        {
            this.issuanceDto = issuanceDto;
        }
    }
}
