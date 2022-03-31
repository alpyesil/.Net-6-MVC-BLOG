using Microsoft.AspNetCore.Mvc;

namespace App.AspNetMvcBlog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
