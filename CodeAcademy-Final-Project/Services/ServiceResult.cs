using CodeAcademy_Final_Project.Models;

namespace CodeAcademy_Final_Project.Services
{
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string? Key { get; set; }
        public string? ErrorMessage { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
