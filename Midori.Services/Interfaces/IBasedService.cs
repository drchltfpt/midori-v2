using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Midori.Services.Interfaces
{
    public interface IBasedService<T>
    {
        Task<IList<T>> GetList();
        Task<IPagedList<T>> GetListPaging(int page = 1, int pageSize = 25);
        Task<T> GetDetail(object id);
        Task Create(T entity);
        Task Update(T updatedEntity);
        Task Delete(object id);
    }
}
