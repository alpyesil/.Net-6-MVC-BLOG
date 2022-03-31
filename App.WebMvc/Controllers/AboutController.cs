using Microsoft.AspNetCore.Mvc;

namespace App.AspNetMvcBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
