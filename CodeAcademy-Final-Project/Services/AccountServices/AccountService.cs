using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.ViewModels.AccountVM;
using Microsoft.AspNetCore.Identity;

namespace CodeAcademy_Final_Project.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;



        public AccountService(UserManager<AppUser> userManager, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _context = appDbContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<ServiceResult> LoginService(LoginVM loginVM)
        {

            if (loginVM == null) return null;
            var user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
                if (user == null)
                {

                    return new ServiceResult { Success = false, Key = "UserNameOrEmail", ErrorMessage = "UserNameOrEmail / Password is wrong" };
                }
            }
            if (!user.EmailConfirmed)
            {
                await _signInManager.SignOutAsync();
                return new ServiceResult { Success=false,Key= "Verify" , ErrorMessage= "Hesabiniz Verify olunmayib!" };
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RemeberMe, true);
            if (result.IsLockedOut)
            {
                return new ServiceResult { Success = false, Key = "UserNameOrEmail", ErrorMessage = "Hesabininz bloklanib" };
            }
            if (!result.Succeeded)
            {
                return new ServiceResult { Success = false, Key = "Password", ErrorMessage = "Password is wrong" };
            }
            await _signInManager.SignInAsync(user, true);

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



            return new ServiceResult { Success = true,AppUser=user };
        }

        public async Task<List<ServiceResult>> RegisterServ(RegisterVM registerVM)
        {
            var serviceResultList = new List<ServiceResult>();

            if (await _userManager.FindByEmailAsync(registerVM.Email) != null)
            {
                serviceResultList.Add(new ServiceResult { Success = false, Key = "Email", ErrorMessage = "Bu email adina hesab movcuddur!" });
              return serviceResultList;
            }
            var role = await _roleManager.FindByNameAsync("Member");
            AppUser user = new();
            user.UserName = registerVM.UserName;
            user.FullName = registerVM.FullName;
            user.Email = registerVM.Email;

            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
               
                foreach (var error in result.Errors)
                {
                    serviceResultList.Add(new ServiceResult { Success = false, Key ="Error", ErrorMessage = error.Description.ToString() });
                   
                }

                return serviceResultList;
                
            }

            LoginVM loginVM = new();
            loginVM.UserNameOrEmail = registerVM.UserName;
            loginVM.Password = registerVM.Password;





            await _userManager.AddToRoleAsync(user, role.ToString());
            await _userManager.UpdateAsync(user);
            serviceResultList.Add(new ServiceResult { Success = true ,AppUser=user});
       
            return serviceResultList;
        }
    }
}
