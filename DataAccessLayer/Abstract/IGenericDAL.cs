using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        string Insert(T entity);
        string Delete(T entity);
        string Update(T entity);
        List<T> GetAllList();
        T GetById(int id);
    }
}
