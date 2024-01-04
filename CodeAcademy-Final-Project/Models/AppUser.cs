using Microsoft.AspNetCore.Identity;

namespace CodeAcademy_Final_Project.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public List<WishList> WishLists { get; set; }
    }
}
