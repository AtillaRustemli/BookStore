using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.ViewModels.AccountVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;



        public AccountController(UserManager<AppUser> userManager, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _context = appDbContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(await _userManager.FindByEmailAsync(registerVM.Email)!=null) {
               ModelState.AddModelError("Email","Bu email adina hesab movcuddur!");
            }
            var role= await _roleManager.FindByNameAsync("Member");
            AppUser user = new();
            user.UserName = registerVM.UserName;
            user.FullName = registerVM.FullName;
            user.Email = registerVM.Email;

            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("password", error.Description.ToString());
                }
                return View(registerVM);
            }

            LoginVM loginVM = new();
            loginVM.UserNameOrEmail= registerVM.UserName;
            loginVM.Password = registerVM.Password;

            await _userManager.AddToRoleAsync(user, role.ToString());
            await _userManager.UpdateAsync(user);
            _context.SaveChanges();


            return RedirectToAction("Login", loginVM);
        }
        [HttpGet]
         public async Task<IActionResult> Login(LoginVM? loginVM)
        {
            ModelState.Clear();
            if (!ModelState.IsValid) return View();
            if (loginVM == null) return View();
            return View(loginVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (loginVM == null) return View();
            var user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if ( user== null)
            {
                user=await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError("UserNameOrEmail", "UserNameOrEmail sehvdir!");
                    return View();
                }
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RemeberMe, true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Heabiniz blokanib!");
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password is wrong!");
            }
            await _signInManager.SignInAsync(user, true);
            if (ReturnUrl != null)
            {
                Redirect(ReturnUrl);
            }
            var role = await _userManager.GetRolesAsync(user);
            //foreach (var item in role)
            //{
            //    if (item == "Admin" && user.EmailConfirmed) return RedirectToAction("index", "dashboard", new { area = "AdminArea" });

            //}
            //if (!user.EmailConfirmed)
            //{
            //    ModelState.AddModelError("Verify", "Hesabiniz Verify olunmayib!");
            //    await _signInManager.SignOutAsync();
            //    return View();
            //}

            return RedirectToAction("Index","BookHome");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "home");
        }

    }
}
