using App.DataAccessLayer.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.AspNetMvcBlog.ViewComponents
{
    public class MainHeadViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public MainHeadViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var threePost =  await _db.Posts
                .Include(e => e.User)
                .Include(e => e.Categories).ToListAsync();

            var rnd = new Random();

            threePost.OrderBy(x => rnd.Next()).Take(3).ToList();

            return View(threePost);
        }

    }
}
