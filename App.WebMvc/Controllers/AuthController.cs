using App.AspNetMvcBlog.Models;
using App.BusinessLayer.Dtos;
using App.BusinessLayer.Services;
using App.DataAccessLayer.Data;
using AspNetMvcSocial.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace App.AspNetMvcBlog.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserService _userService;

        public AuthController(AppDbContext db, UserService userService)
        {
            _db = db;
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel, string returnUrl = null)
        {
            if (loginModel.UserName != null && loginModel.Password != null)
            {
                var loginVerify = _db.Users.FirstOrDefault(e =>
                e.UserName == loginModel.UserName ||
                e.Email == loginModel.UserName &&
                e.Password == loginModel.Password);

                if (loginVerify != null)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, loginVerify.Id.ToString()),
                        new Claim(ClaimTypes.Name, loginVerify.UserName),
                        new Claim(ClaimTypes.GivenName, loginVerify.Name ?? " "),
                        new Claim(ClaimTypes.Email, loginVerify.Email),
                    };

                    if (!string.IsNullOrEmpty(loginVerify.Roles))
                    {
                        var rolesArr = loginVerify.Roles.Split(',');
                        foreach (var role in rolesArr)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role.Trim()));
                        }
                    }

                    // ClaimsIdenetiy (Kimlik)
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Principle (Cüzdan)
                    var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

                    var authProperties = new AuthenticationProperties()
                    {
                        IsPersistent = loginModel.RememberMe,
                        ExpiresUtc = DateTime.Now.AddMinutes(180),
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        claimsPrinciple,
                        authProperties
                        );

                    return Redirect(returnUrl == null ? "/" : returnUrl);
                }
            }

            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Register(RegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                var userDto = await _userService.CreateUser(new UserDto
                {
                    Email = user.Email,
                    UserName = user.UserName,
                    Password = user.Password,
                });

                return RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}