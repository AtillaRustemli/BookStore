using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.Services.AccountServices;
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
        private readonly IAccountService _accountService;



        public AccountController(UserManager<AppUser> userManager, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, IAccountService accountService)
        {
            _userManager = userManager;
            _context = appDbContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _accountService = accountService;
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
        public async Task<IActionResult> Login(LoginVM loginVM, string? ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (loginVM == null) return View();
            var serviceRespond=await _accountService.LoginService(loginVM);
            var user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if (!serviceRespond.Success)
            {
                ModelState.AddModelError(serviceRespond.Key, serviceRespond.ErrorMessage);
                return View();
            }

          
            if (ReturnUrl != null)
            {
                Redirect(ReturnUrl);
            }
          
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
