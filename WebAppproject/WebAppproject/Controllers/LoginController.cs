using Microsoft.AspNetCore.Mvc;

namespace WebAppproject.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Add logic for authentication
            // Redirect to Dashboard on successful login
            return RedirectToAction("Index", "Dashboard", new { username = username });
        }

    }
}
