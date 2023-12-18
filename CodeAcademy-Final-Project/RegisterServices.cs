using CodeAcademy_Final_Project.DAL;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project
{
    public static class RegisterServices
    {
        public static void Register(this IServiceCollection services,IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddHttpContextAccessor();
        }
    }
}
