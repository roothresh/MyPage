using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            this.blogDAL = blogDAL;
        }

        public string BlogAdd(BlogEntity categoryEntity)
        {
            throw new NotImplementedException();
        }

        public string BlogCancel(BlogEntity categoryEntity)
        {
            throw new NotImplementedException();
        }

        public string BlogUpdate(BlogEntity categoryEntity)
        {
            throw new NotImplementedException();
        }

        public List<BlogEntity> GetAllBlog()
        {
            return blogDAL.GetAllList();
        }

        public BlogEntity GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BlogEntity> GetBlogsListWithCategory()
        {
            return blogDAL.GetListWithCategories();
        }
    }
}
