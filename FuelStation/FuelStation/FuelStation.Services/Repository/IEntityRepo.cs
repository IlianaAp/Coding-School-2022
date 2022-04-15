using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Services.Repository
{
    public interface IEntityRepo<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<string> CreateAsync(TEntity entity);
        Task<string> UpdateAsync(TEntity entity);
        Task<string> DeleteAsync(Guid id);
    }
}
