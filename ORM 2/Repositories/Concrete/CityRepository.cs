using Microsoft.EntityFrameworkCore;
using ORM_2.DataAccess;
using ORM_2.Entities;
using ORM_2.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORM_2.Repositories.Concrete
{
    class CityRepository : IRepository<City>
    {
        private readonly OneToOneDBContext _context;
        public CityRepository(OneToOneDBContext context)
        {
            _context = context;
        }


        public City Add(City obj)
        {
            var addedObj = _context.Cities.Add(obj);
            return addedObj.Entity;
        }

        public bool Delete(City obj)
        {
            return _context.Cities.Remove(obj) != null;
        }

        public City? Get(Expression<Func<City, bool>> exp)
        {
            return _context.Cities.FirstOrDefault(exp);
        }

        public City? get(int id)
        {
            return _context.Cities.SingleOrDefault(c=>c.ID==id);
        }

        public IEnumerable<City> GetAll()
        {
            return _context.Cities.Include(nameof(Country));
        }

        public IEnumerable<City> GetAll(Expression<Func<City, bool>> exp)
        {
            return exp != null ? _context.Cities.Where(exp) : _context.Cities;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public City Update(City obj)
        {
            var updatedObj = _context.Cities.Update(obj);
            return updatedObj.Entity;
        }
    }
}
