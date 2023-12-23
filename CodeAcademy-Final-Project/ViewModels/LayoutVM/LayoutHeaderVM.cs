using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.ViewModels.LayoutVM
{
    public class LayoutHeaderVM
    {
        public List<BType> BookTypesInSearch { get; set; }
        public Dictionary<string,string> SettingKeyValue { get; set; }
    }
}
