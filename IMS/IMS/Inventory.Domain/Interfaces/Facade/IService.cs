using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Facade
{
    public interface IService<T> where T : class
    {
        Task<List<T>> GetAllIssuance();

        Task<int> AddIssuance(T issuance);

        bool UpdateIssuance(T issuance);

        bool DeleteIssuance(T issuance);
    }
}
