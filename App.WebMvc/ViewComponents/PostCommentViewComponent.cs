using Microsoft.AspNetCore.Mvc;

namespace App.AspNetMvcBlog.ViewComponents
{
    public class PostCommentViewComponent : ViewComponent
    {
        public PostCommentViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return View(); 
        }
    }
}
