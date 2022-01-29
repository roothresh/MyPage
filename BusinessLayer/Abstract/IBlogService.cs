using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        string BlogAdd(BlogEntity categoryEntity);
        string BlogCancel(BlogEntity categoryEntity);
        string BlogUpdate(BlogEntity categoryEntity);
        List<BlogEntity> GetAllBlog();
        BlogEntity GetBlogById(int id);
        List<BlogEntity> GetBlogsListWithCategory();
    }
}
