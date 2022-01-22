using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public string Delete(T entity)
        {
            using var c = new MyContext();
            c.Update(entity);
            c.SaveChanges();
            return "OK";
        }

        public List<T> GetAllList()
        {
            using var c = new MyContext();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new MyContext();
            return c.Set<T>().Find(id);
        }

        public string Insert(T entity)
        {
            using var c = new MyContext();
            c.Add(entity);
            c.SaveChanges();
            return "OK";
        }

        public string Update(T entity)
        {
            using var c = new MyContext();
            c.Update(entity);
            c.SaveChanges();
            return "OK";
        }
    }
}
