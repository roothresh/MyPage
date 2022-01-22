using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        MyContext myContext = new MyContext();
        public string AddCategory(CategoryEntity category)
        {
            myContext.Add(category);
            myContext.SaveChanges();
            return "OK";
        }

        public string CancelCategory(CategoryEntity category)
        {
            myContext.Update(category);
            myContext.SaveChanges ();
            return "OK";
        }

        public string Delete(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CategoryEntity> GetAllList()
        {
            throw new NotImplementedException();
        }

        public CategoryEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryEntity GetCategoryById(int id)
        {
            return myContext.Categories.Find(id);
        }

        public string Insert(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<CategoryEntity> ListAllCategory()
        {
            return myContext.Categories.ToList();
        }

        public string Update(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public string UpdateCategory(CategoryEntity category)
        {
            myContext.Update(category);
            myContext.SaveChanges();
            return "OK";
        }
    }
}
