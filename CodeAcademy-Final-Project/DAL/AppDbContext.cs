using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
