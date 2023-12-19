using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM vm = new();
            return View(await Task.FromResult(vm));
        }
    }
}
