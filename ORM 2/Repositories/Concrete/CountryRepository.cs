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
    class CountryRepository:IRepository<Country>
    {
        private readonly OneToOneDBContext _context;
        public CountryRepository(OneToOneDBContext context)
        {
            _context = context;
        }


        public Country Add(Country obj)
        {
            var addedObj = _context.Countries.Add(obj);
            return addedObj.Entity;
        }

        public bool Delete(Country obj)
        {
            return _context.Countries.Remove(obj) != null;
        }

        public Country? Get(Expression<Func<Country, bool>> exp)
        {
            return _context.Countries.FirstOrDefault(exp);
        }

        public Country? get(int id)
        {
            return _context.Countries.SingleOrDefault(c => c.ID == id);
        }

        public IEnumerable<Country> GetAll()
        {
            return _context.Countries.Include(nameof(City));
        }

        public IEnumerable<Country> GetAll(Expression<Func<Country, bool>> exp)
        {
            return exp != null ? _context.Countries.Where(exp) : _context.Countries;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public Country Update(Country obj)
        {
            var updatedObj = _context.Countries.Update(obj);
            return updatedObj.Entity;
        }
    }
}

