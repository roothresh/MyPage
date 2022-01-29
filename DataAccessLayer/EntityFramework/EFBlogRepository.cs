using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<BlogEntity>, IBlogDAL
    {
        public List<BlogEntity> GetListWithCategories()
        {
            using(var ctx = new MyContext())
            {
                return ctx.Blogs.Include(x => x.Categories).ToList();
            }
        }
    }
}
