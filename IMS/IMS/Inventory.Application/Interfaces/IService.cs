using Inventory.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Interfaces
{
    public interface IService<T, V> where T : class where V : class
    {
        Task<ResponseDto<T>> GetAllIssuance();

        Task<ResponseDto<T>> AddIssuance(V issuance);

        bool UpdateIssuance(V issuance);

        bool DeleteIssuance(int id);

        //ResponseDto<T> GetIssuanceByCriteria(Expression<Func<W, bool>> filter);

        //Task<ResponseDto<T>> Get(Expression<Func<V, bool>> filter, Func<IQueryable<V>, IOrderedQueryable<V>> orderBy , string includeProperties);


    }
}
