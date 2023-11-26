using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CorseUILayer.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Index(Admin p)
        {
            var result = c.Admins.FirstOrDefault(x =>
            x.User == p.User && x.Password == p.Password);
           if(result!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.User)
                };

                var UserIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(UserIdentity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Language");


            }
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        { 
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }


    }
}
