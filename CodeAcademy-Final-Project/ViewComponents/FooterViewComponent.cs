using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy_Final_Project.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            BookHomeVM vm = new();
            return View(await Task.FromResult(vm));
        }
    }
}
