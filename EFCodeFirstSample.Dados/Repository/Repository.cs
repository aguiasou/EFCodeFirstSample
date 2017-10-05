using EFCodeFirstSample.Negocios.Entidades;
using EFCodeFirstSample.Negocios.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace EFCodeFirstSample.Dados.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }

        public T FindById(long id)
        {
            return context.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Save(T entity)
        {
            context.Set<T>().(entity);
            context.SaveChanges();
        }
    }
}
