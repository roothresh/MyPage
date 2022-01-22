using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _cateogryDAL;

        public CategoryManager(ICategoryDAL cateogryDAL)
        {
            _cateogryDAL = cateogryDAL;
        }

        public string CategoryAdd(CategoryEntity categoryEntity)
        {
            
            return _cateogryDAL.Insert(categoryEntity);
            
        }

        public string CategoryCancel(CategoryEntity categoryEntity)
        {
            return _cateogryDAL.Delete(categoryEntity);
        }

        public string CategoryUpdate(CategoryEntity categoryEntity)
        {
            return _cateogryDAL.Update(categoryEntity);
        }

        public List<CategoryEntity> GetAllCategories()
        {
            return _cateogryDAL.GetAllList();
        }

        public CategoryEntity GetCategoryById(int id)
        {
            return _cateogryDAL.GetById(id);
        }
    }
}
