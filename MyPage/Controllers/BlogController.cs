using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyPage.Controllers
{
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogsListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
