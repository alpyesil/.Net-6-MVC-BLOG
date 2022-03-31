using System.ComponentModel.DataAnnotations;

namespace App.AspNetMvcBlog.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [MinLength(3)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
