using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.Areas.AdminArea.Controllers
{
        [Area(nameof(AdminArea))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
