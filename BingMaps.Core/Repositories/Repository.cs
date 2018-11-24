using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BingMaps.Core.Domain;
using BingMaps.Core.EF;

namespace BingMaps.Core.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly BingMapContext _context;

        public Repository(BingMapContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll() => _context.Set<T>();


        public T Get(int id)
        {
           return _context.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public void Update(T entity)
        {
            var existing = Get(entity.Id);
            _context.Entry(existing).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
