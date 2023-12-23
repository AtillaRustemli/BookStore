using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;

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
            vm.Books=_context.Book.ToList();
            vm.Categories=_context.Categories.ToList();
            vm.Promotions=_context.Promotions.ToList();
            vm.Genres=_context.Genre.ToList();
            
            return View(vm);
        }
        public IActionResult Detail(int? id)
        {

            return View();
        }
    }
}
