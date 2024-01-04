using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels.ABookVM;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.Controllers
{
    public class ABookController : Controller
    {
    private readonly AppDbContext _context;

    public ABookController(AppDbContext context)
    {
        _context = context;
    }
        public IActionResult Index()
        {
            ABookHomeVM vm = new();
            vm.ABooks = _context.ABooks
                .Include(b => b.ABookAuthor)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.ABookCategory)
                .ThenInclude(ba => ba.Category)
                .ToList();
            vm.Categories = _context.Categories
                .Include(c => c.ABookCategory)
                .ThenInclude(bc => bc.ABook)
                .Where(c=>c.ABookCategory!=null)
                .ToList();
            vm.Promotions = _context.Promotions.ToList();
            vm.Genres = _context.Genre.ToList();

            return View(vm);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var book = _context.ABooks
                .Include(b => b.ABookCategory)
                .ThenInclude(ba => ba.Category)
                .Include(b => b.Book)
                .ThenInclude(ab => ab.BType)
                .Include(ab => ab.EBook)
                .ThenInclude(eb=>eb.BType)
                .Include(b => b.BType)
                .Include(b => b.ABookAuthor)
                .ThenInclude(ba => ba.Author)
                .ThenInclude(a => a.SocialMedia)
                .Include(b => b.ABookGenre)
                .ThenInclude(ba => ba.Genre)
                .FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();



            return View(book);
        }
    }
}
