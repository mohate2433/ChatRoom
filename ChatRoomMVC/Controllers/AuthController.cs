using CoreLayer.New.UserServices;
using CoreLayer.New.ViewModels.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;

namespace ChatRoomMVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            var result = await _userService.RegisterUser(register);
            if (!result)
            {
                ModelState.AddModelError(register.UserName, "نام کاربری تکراری است");
                return View("Index" , register);
            }
            return Redirect("/Auth#login");
        }
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
                return View("Index", login);
            var user =await _userService.LoginUser(login);
            if (user == null)
            {
                ModelState.AddModelError(login.UserName, "نام کاربری وارد شده صحیح نمیباشد");
                return View("Index", login);
            }
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier , user.ID.ToString()),
                new Claim(ClaimTypes.Name , user.UserName.ToString())
            };
            var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            var properties = new AuthenticationProperties()
            {
                IsPersistent = true
            };
            HttpContext.SignInAsync(principal );
            return Redirect("/");
        }
    }
}
