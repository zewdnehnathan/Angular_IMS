using System.Collections.Generic;

namespace Inventory.Application.Dtos
{
    public class GenericResponseDto<T>
    {
        public List<T> Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public GenericResponseDto(List<T> data, bool isSuccess, string message)
        {
            Data = data;
            IsSuccess = isSuccess;
            Message = message;
        }
        public GenericResponseDto(T data, bool isSuccess, string message)
        {
            Data = new List<T> { data };
            IsSuccess = isSuccess;
            Message = message;
        }
        public GenericResponseDto(List<T> data, string message)
        {
            Data = data;
            IsSuccess = false;
            Message = message;
        }
        public GenericResponseDto(List<T> data)
        {
            Data = data;
            IsSuccess = true;
        }
        public GenericResponseDto(T data)
        {
            Data = new List<T> { data };
            IsSuccess = true;
        }
        public GenericResponseDto(bool isSuccess, string message)
        {
            Data = null;
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
