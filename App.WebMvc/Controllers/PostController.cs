using App.DataAccessLayer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.AspNetMvcBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _db;

        public PostController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Detail(int i)
        {
            var postDetail = await _db.Posts
                .Include(e => e.User)
                .Include(e => e.CategoryPosts)
                .ThenInclude(e => e.Category)
                .Include(e => e.PostTags)
                .FirstOrDefaultAsync(e => e.Id == i);

            return View(postDetail);
        }

        public async Task<IActionResult> Search(string s)
        {
            var searchList = await _db.Posts
                .Include(e => e.CategoryPosts)
                .ThenInclude(e => e.Category)
                .Where(e => e.Title.Contains(s) || e.Content.Contains(s)).ToListAsync();          

            return View(searchList);
        }
    }
}
