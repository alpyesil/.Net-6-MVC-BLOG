using App.DataAccessLayer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.AspNetMvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int q)
        {
            var categoryList = await _db.Category
                .Include(x => x.CategoryPosts)
                .ThenInclude(x => x.Post).FirstOrDefaultAsync(e => e.Id == q);
              

            return View(categoryList);
        }
    }
}
