using CodeAcademy_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }

    }
}
