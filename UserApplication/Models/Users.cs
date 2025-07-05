using Microsoft.AspNetCore.Identity;

namespace UserApplication.Models
{
    public class Users : IdentityUser
    {

        public String FullName { get; set; }
    }
}
