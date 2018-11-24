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
        T Get(int id); 
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);        
    }
}
