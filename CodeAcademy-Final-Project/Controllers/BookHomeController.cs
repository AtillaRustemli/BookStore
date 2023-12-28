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

        public IActionResult Index(string?type)
        {
            BookHomeVM vm = new();
            vm.Books=_context.Book
                .Include(b=>b.BookCategory)
                .ToList();
            vm.Categories=_context.Categories
                .Include(c=>c.BookCategory)
                .ThenInclude(bc=>bc.Book)
                .ToList();
            vm.Promotions=_context.Promotions.ToList();
            vm.Genres=_context.Genre.ToList();
            
            return View(vm);
        }
        public IActionResult Detail(int? id,int?typeId=1)
        {
            if (id == null) return NotFound();
            var book = _context.Book
                .FirstOrDefault(b=>b.Id==id);
            if(book == null) return NotFound();
           

            return View(book);
        }
    }
}
