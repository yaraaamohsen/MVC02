using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC_Session2.Controllers
{
    public class HomeController : Controller
    {
        // View => HTML Page
        // Razor Page => HTML + C#
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
