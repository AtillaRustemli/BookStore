using CodeAcademy_Final_Project.DAL;
using CodeAcademy_Final_Project.Models;
using CodeAcademy_Final_Project.ViewModels.BookViewModel;
using CodeAcademy_Final_Project.ViewModels.LayoutVM;
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
            LayoutHeaderVM vm= new ();
            vm.BookTypesInSearch=_context.BTypes.ToList();
            vm.SettingKeyValue= _context.SettingKeyValue.ToDictionary(c => c.Key, c => c.Value);

           
            return View(await Task.FromResult(vm));
        }
    }
}
