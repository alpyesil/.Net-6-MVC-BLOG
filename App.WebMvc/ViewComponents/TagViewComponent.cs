using Microsoft.AspNetCore.Mvc;

namespace App.AspNetMvcBlog.ViewComponents
{
    public class TagViewComponent : ViewComponent
    {
        public TagViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
