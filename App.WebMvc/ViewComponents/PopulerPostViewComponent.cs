using Microsoft.AspNetCore.Mvc;

namespace App.AspNetMvcBlog.ViewComponents
{
    public class PopulerPostViewComponent : ViewComponent
    {

        public PopulerPostViewComponent()
        {
           
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
        

    }
    
}
