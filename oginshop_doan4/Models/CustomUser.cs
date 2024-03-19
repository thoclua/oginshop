using Microsoft.AspNetCore.Identity;

namespace oginshop_doan4.Models
{
    public class CustomUser : IdentityUser
    {
        public string FullName { get; set; } = "";
    }
}
