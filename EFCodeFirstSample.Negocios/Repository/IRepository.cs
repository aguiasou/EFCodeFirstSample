using EFCodeFirstSample.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstSample.Negocios.Repository
{
    public interface IRepository<T> where T : Entity
    {
        void Save(T entity);
        void Delete(T entity);
        T FindById(long id);
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();

    }
}
