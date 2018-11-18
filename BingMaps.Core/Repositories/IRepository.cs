using BingMaps.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMaps.Core.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetAsync(Guid id);
        Task<IQueryable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);        
    }
}
