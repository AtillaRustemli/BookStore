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
                .Include(b => b.BookBaseAuthor)
                .ThenInclude(ba => ba.Author)
                .Where(b=>b.BTypeId==1)
                .Include(b => b.BookBaseCategory)
                .ToList();
            vm.Categories=_context.Categories
                .Include(c=>c.BookBaseCategory)
                .ThenInclude(bc=>bc.Book)
                .ToList();
            vm.Promotions=_context.Promotions.ToList();
            vm.Genres=_context.Genre.ToList();
            
            return View(vm);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var book = _context.Book
                .FirstOrDefault(b=>b.Id==id);
            if(book == null) return NotFound();
           

            return View(book);
        }
    }
}
