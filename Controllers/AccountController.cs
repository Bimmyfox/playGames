using Microsoft.AspNetCore.Mvc;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class AccountController : Controller
    {
        // Display login page
        public IActionResult Login()
        {
            return View();
        }

        // Handle login POST request
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            // Dummy login verification
            if (user.Username == "admin" && user.Password == "1111")
            {
                user.IsAdmin = true; // Set as admin
            }
            else if (user.Username == "user" && user.Password == "1111")
            {
                user.IsAdmin = false; // Set as regular user
            }
            else
            {
                ViewBag.Message = "Invalid credentials";
                return View();
            }

            // Use TempData instead of Session for simple data storage
            TempData["IsAdmin"] = user.IsAdmin;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}