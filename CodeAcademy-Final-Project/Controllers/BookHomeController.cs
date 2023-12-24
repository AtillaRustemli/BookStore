using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.Controllers
{
    public class BookHomeController : Controller
    {
        private readonly AppDbContext _context;

        public BookHomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BookHomeVM vm = new();
            vm.Books=_context.Book
                .Include(b=>b.BookType)
                .Include(b=>b.BookCategory)
                .Include(b=>b.AuthorBook)
                .ThenInclude(b=>b.Author)
                .ToList();
            vm.Categories=_context.Categories
                .Include(c=>c.BookCategory)
                .ThenInclude(bc=>bc.Book)
                .ToList();
            vm.Promotions=_context.Promotions.ToList();
            vm.Genres=_context.Genre.ToList();
            
            return View(vm);
        }
        public IActionResult Detail(int? id)
        {
            var book = _context.Book
                .Include (b=>b.BookType)
                .ThenInclude(bt=>bt.BType)
                .Include(bt=>bt.AuthorBook)
                .ThenInclude (bt=>bt.Author)
                .FirstOrDefault(b=>b.Id==id);

            return View(book);
        }
    }
}
