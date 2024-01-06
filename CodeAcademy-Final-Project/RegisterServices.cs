using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Helpers.ErrorDescriber;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.Models.EmailModel;
using CodeAcademy_Final_Project.Services.AccountServices;
using CodeAcademy_Final_Project.Services.EmailService;
using CodeAcademy_Final_Project.Validators.AccountValidators;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project
{
    public static class RegisterServices
    {
        public static void Register(this IServiceCollection services,IConfiguration config)
        {
            services.AddControllersWithViews().AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblyContaining<RegisterVMValidator>());
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddHttpContextAccessor();
            services.AddIdentity<AppUser, IdentityRole>(identityOptions =>
            {
                identityOptions.SignIn.RequireConfirmedEmail = true;
                identityOptions.Password.RequireNonAlphanumeric = true;
                identityOptions.Password.RequiredLength = 8;
                identityOptions.Password.RequireDigit = true;
                identityOptions.Password.RequireLowercase = true;
                identityOptions.Password.RequireUppercase = true;

                identityOptions.User.RequireUniqueEmail = true;
                identityOptions.Lockout.MaxFailedAccessAttempts = 5;
                identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                identityOptions.Lockout.AllowedForNewUsers = true;
            })
               .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<AppDbContext>()
               .AddErrorDescriber<CustomIdentityErrorDescriber>();

            services.Configure<EmailConfig>(config.GetSection(nameof(EmailConfig)));
            services.AddScoped<EmailConfig>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEmailService, EmailService>();



        }
    }
}
