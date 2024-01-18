using Microsoft.AspNetCore.Mvc;

namespace WebAppproject.Controllers
{
    public class DashBoardController : Controller
    {
       
        public IActionResult Index(string username)
        {
            ViewBag.Username = username;
            return View();
        }
        [HttpPost]
        public IActionResult Logout()
        {
            // Add logic for logout
            // Redirect to Login page
            return RedirectToAction("Login", "Login");
        }
    }
}
