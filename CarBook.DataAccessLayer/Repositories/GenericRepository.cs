using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CarBookContext context = new CarBookContext();
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
