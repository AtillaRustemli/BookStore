using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.Areas.AdminArea.Controllers
{
        [Area(nameof(AdminArea))]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
         var book= _context.Book.ToList();
           
            return View(book);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(string?search)
        {
            List<Book> book =new();
            if (search == null) { 
            book=_context.Book.ToList();
            }
            else
            {
                book=_context.Book.Where(b=>b.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            return View(book);
        }
    }
}
