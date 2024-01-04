using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels.ABookVM;
using CodeAcademy_Final_Project.ViewModels.EBookVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.Controllers
{
    public class EBookController : Controller
    {
        private readonly AppDbContext _context;

        public EBookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            EBookHomeVM vm = new();
            vm.EBooks = _context.EBooks
                .Include(b => b.EBookAuthor)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.EBookCategory)
                .ThenInclude(ba => ba.Category)
                .ToList();
            vm.Categories = _context.Categories
                .Include(c => c.EBookCategory)
                .ThenInclude(bc => bc.EBook)
                .Where(c => c.EBookCategory != null)
                .ToList();
            vm.Promotions = _context.Promotions.ToList();
            vm.Genres = _context.Genre.ToList();

            return View(vm);
        }
        public IActionResult Detail(int?id)
        {
            if (id == null) return NotFound();
            var book = _context.EBooks
                .Include(b => b.EBookCategory)
                .Include(b => b.Book)
                .ThenInclude(ab => ab.BType)
                .Include(ab => ab.ABook)
                .ThenInclude(eb => eb.BType)
                .Include(b => b.BType)
                .Include(b => b.EBookAuthor)
                .ThenInclude(ba => ba.Author)
                .ThenInclude(a => a.SocialMedia)
                .Include(b => b.EBookGenre)
                .ThenInclude(ba => ba.Genre)
                .FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();



            return View(book);
        }
    }
}
