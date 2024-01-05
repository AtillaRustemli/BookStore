using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
