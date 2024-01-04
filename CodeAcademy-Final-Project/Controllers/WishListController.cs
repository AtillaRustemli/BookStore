using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
