using Backend_Final.Extensions;
using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.Models.ReletionTables;
using CodeAcademy_Final_Project.ViewModels;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy_Final_Project.Areas.AdminArea.Controllers
{
        [Area(nameof(AdminArea))]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var category = _context.Categories
                .Include(c=>c.BookBaseCategory)
                .ThenInclude(c=>c.Book)
                .ThenInclude(b=>b.BookAuthor)
                .ThenInclude(ba=>ba.Author)
                .Include(c=>c.ABookCategory)
                .ThenInclude(c=>c.ABook)
                .ThenInclude(b=>b.ABookAuthor)
                .ThenInclude(ba=>ba.Author)
                .Include(c=>c.EBookCategory)
                .ThenInclude(c=>c.EBook)
                .ThenInclude(b=>b.EBookAuthor)
                .ThenInclude(ba=>ba.Author)
                .FirstOrDefault(c => c.Id == id);
            return View();
        }
    }
}
