using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.Services.AccountServices;
using CodeAcademy_Final_Project.ViewModels.AccountVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.Mail;
using System.Net;
using CodeAcademy_Final_Project.Services.EmailService;
using CodeAcademy_Final_Project.Models.EmailModel;

namespace CodeAcademy_Final_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly IAccountService _accountService;
        private readonly EmailConfig _emailConfig;



        public AccountController(UserManager<AppUser> userManager, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, IAccountService accountService, EmailConfig emailConfig)
        {
            _userManager = userManager;
            _context = appDbContext;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _accountService = accountService;
            _emailConfig = emailConfig;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            int count = 0;
            if (!ModelState.IsValid)
            {
                return View();
            }
            var registerService =await _accountService.RegisterServ(registerVM);
            foreach (var register in registerService)
            {
                count++;
                if (!register.Success)
                {
                    ModelState.AddModelError(register.Key, register.ErrorMessage);
                if (count == registerService.Count)
                {
                    return View();
                }

                }
            }


            var token = await _userManager.GenerateEmailConfirmationTokenAsync(registerService[0].AppUser);
            var url = Url.Action(nameof(VerifyEmail), "Account", new { email = registerService[0].AppUser.Email, token }, Request.Scheme, Request.Host.ToString());
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("atillaproject52@gmail.com", "VerifyEmail");
            mailMessage.To.Add(registerService[0].AppUser.Email);
            mailMessage.Subject = "Verify your Email";
            string body = string.Empty;

            using (StreamReader streamReader = new("wwwroot/Templates/VerifyEmail.html"))
            {
                body = streamReader.ReadToEnd();
            }
            mailMessage.Body = body.Replace("{{link}}", url);
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(_emailConfig.From, _emailConfig.Password);
            smtpClient.Send(mailMessage);

            var wishList=new WishList();
            wishList.Name = "Wishlist";
            wishList.IsPrivate = true;
            wishList.IsMain=true;
            wishList.AppUserId = registerService[0].AppUser.Id;
            _context.WishLists.Add(wishList);
            


            LoginVM loginVM = new();
            loginVM.UserNameOrEmail= registerVM.UserName;
            loginVM.Password = registerVM.Password;



            _context.SaveChanges();
            return RedirectToAction("Login", loginVM);
        }

        public async Task<IActionResult> VerifyEmail(string email, string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null) return NotFound();
            
            await _userManager.ConfirmEmailAsync(user, token);
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("index", "bookhome");
        }

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
            return RedirectToAction("Index", "bookhome");
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>  ForgetPassword(ForgetPasswordVM forgetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Bosh saxlamaq olmaz!");
                return View();
            }
            var user=await _userManager.FindByEmailAsync(forgetPasswordVM.Email);
            if(user == null)
            {
                ModelState.AddModelError("Error", "Email tapilmadi!");
                return View();
            }

            var token=await _userManager.GeneratePasswordResetTokenAsync(user);
            var link = Url.Action(nameof(ResetPassword), "Account", new {email=forgetPasswordVM.Email,token=token},Request.Scheme,Request.Host.ToString());

            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress(_emailConfig.From, _emailConfig.UserName);
            mailMessage.IsBodyHtml = true;
            mailMessage.To.Add(user.Email);
            mailMessage.Subject = "Reset Password";
            mailMessage.Body = $"<a href={link}>Click Here to start reseting Password</a>";

            SmtpClient smtpClient = new();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(_emailConfig.From, _emailConfig.Password);
            smtpClient.Send(mailMessage);
            return RedirectToAction("index","bookhome");
        }
        public IActionResult ResetPassword(string email,string token)
        {
            ViewData["email"] = email;
            ViewData["token"] = token;
        return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(string email,string token, ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user= await _userManager.FindByEmailAsync(email);
            if (user == null) return BadRequest();
            await _userManager.ChangePasswordAsync(user,token, resetPasswordVM.Password);
        return RedirectToAction("index","bookhome");
        }
    }
}
