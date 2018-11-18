using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingMaps.Core.Domain;

namespace BingMaps.Core.Repositories
{
    public class Repository : IRepository<Point>
    {
        public Task AddAsync(Point entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Point entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Point>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Point> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Point entity)
        {
            throw new NotImplementedException();
        }
    }
}
