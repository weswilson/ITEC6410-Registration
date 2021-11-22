using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using System.Security.Claims;

namespace Registration.Controllers
{
    
    public class AccountController : Controller
    {
        private List<ApplicationUser> _applicationUsers = new List<ApplicationUser>
        {
            new ApplicationUser { Username = "staff", Password = "password", Role = "Staff", RoleId = 1 },
            new ApplicationUser { Username = "staff2", Password = "password", Role = "Staff", RoleId = 2 },
            new ApplicationUser { Username = "student", Password = "password", Role = "Student", RoleId = 1 },
            new ApplicationUser { Username = "student2", Password = "password", Role = "Student", RoleId = 2 },
        };

        [HttpPost]
        public async Task<IActionResult> Login([Bind("username")] string username, [Bind("password")] string password)
        {
            var user = AuthenticateUser(username, password);

            if (user == null)
            {
                //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return RedirectToAction("Index", "Course");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim("RoleId", user.RoleId.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {

            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return RedirectToAction("Index", "Course");
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Course");
        }

        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

        private ApplicationUser AuthenticateUser(string username, string password)
        {
            return _applicationUsers.Find(u => u.Username == username && u.Password == password);
        }
        
    }
}
