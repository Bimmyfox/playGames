using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestTask.Models;

namespace TestTask.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Retrieve the admin status from TempData
        bool isAdmin = TempData.ContainsKey("IsAdmin") && (bool)TempData["IsAdmin"];
        if (isAdmin)
            {
                ViewBag.Message = "Play games";
            }
            else
            {
                ViewBag.Message = "Hello";
            }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}