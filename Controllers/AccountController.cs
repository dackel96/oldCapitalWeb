using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using oldCapitalWeb.Models;

namespace oldCapitalWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;

        private readonly UserManager<IdentityUser> userManager;

        //private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager
                              /*RoleManager<IdentityRole> roleManager*/)
        {
            this.signInManager = signInManager;

            this.userManager = userManager;

            //this.roleManager = roleManager;

        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return (RedirectToAction("Index", "Home"));
            }

            var model = new RegisterViewModel();

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new IdentityUser()
            {
                UserName = model.Username,

                Email = model.Email,

                PhoneNumber = model.PhoneNumber,
            };

            var password = await userManager.CreateAsync(user, model.Password);

            if (password.Succeeded)
            {
                return RedirectToAction(nameof(Login), "Account");
            }

            foreach (var error in password.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (user == null)
            {
                return View(model);
            }

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "InvalidLogin");

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
