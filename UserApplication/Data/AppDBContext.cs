using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApplication.Models;

namespace UserApplication.Data
{
    public class AppDBContext : IdentityDbContext<Users>
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        
    }
}
