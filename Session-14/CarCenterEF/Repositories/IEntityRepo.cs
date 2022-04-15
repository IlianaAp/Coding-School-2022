using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCenterEF.Repositories
{
    public interface IEntityRepo<T> where T : class
    {
        List<T> GetAll();
        T? GetById(Guid id);
        Task Create(T entity);
        Task Update(Guid id,T entity);
        Task Delete(Guid id);
    }
}
