using Microsoft.AspNetCore.Mvc;
using SchoolMS.Models;
using System.Diagnostics;

namespace SchoolMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AdminIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Enrollments()
        {
            return View();
        }

        public IActionResult Professors()
        {
            return View();
        }
        public IActionResult TorRequests()
        {
            return View();
        }

        public IActionResult DiplomaRequests()
        {
            return View();
        }

        public IActionResult GradeRequests()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
