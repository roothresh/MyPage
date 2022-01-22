using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        string CategoryAdd(CategoryEntity categoryEntity);
        string CategoryCancel(CategoryEntity categoryEntity);
        string CategoryUpdate(CategoryEntity categoryEntity);
        List<CategoryEntity> GetAllCategories();
        CategoryEntity GetCategoryById(int id);
    }
}
