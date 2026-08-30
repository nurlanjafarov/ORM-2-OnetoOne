using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORM_2.Repositories.Abstract
{
    public interface IRepository<T>
    {
        T? Get(Expression<Func<T, bool>> exp);
        T? get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> exp);
        T Add(T obj);

        T Update(T obj);
        bool Delete(T obj);
        bool SaveChanges();
    }
}
