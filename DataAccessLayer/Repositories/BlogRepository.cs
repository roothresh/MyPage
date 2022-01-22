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
    public class BlogRepository : IBlogDAL
    {
        public string AddCategory(BlogEntity blog)
        {
            using var c = new MyContext();
            c.Add(blog);
            c.SaveChanges();
            return "OK";
        }

        public string CancelCategory(BlogEntity blog)
        {
            using var c = new MyContext();
            c.Update(blog);
            c.SaveChanges();
            return "OK";
        }

        public string Delete(BlogEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BlogEntity> GetAllList()
        {
            throw new NotImplementedException();
        }

        public BlogEntity GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public BlogEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Insert(BlogEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BlogEntity> ListAllCategory()
        {
            throw new NotImplementedException();
        }

        public string Update(BlogEntity entity)
        {
            throw new NotImplementedException();
        }

        public string UpdateCategory(BlogEntity blog)
        {
            throw new NotImplementedException();
        }
    }
}
