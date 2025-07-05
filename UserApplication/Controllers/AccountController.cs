using Microsoft.AspNetCore.Mvc;

namespace UserApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
