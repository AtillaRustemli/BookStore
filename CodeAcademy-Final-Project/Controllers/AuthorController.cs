using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models.ReletionTables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int?id)
        {
            var author=_context.Author
                .Include(a=>a.BookBaseAuthor)
                .ThenInclude(a=>a.Book)
                .ThenInclude(b=>b.BType)
                .Include(a=>a.ABookAuthor)
                .ThenInclude(a=>a.ABook)
                .ThenInclude(b=>b.BType)
                .Include(a=>a.EBookAuthor)
                .ThenInclude(a=>a.EBook)
                .ThenInclude(b=>b.BType)
                .FirstOrDefault(a=>a.Id==id);


            return View(author);
        }
    }
}
