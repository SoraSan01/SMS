using Microsoft.AspNetCore.Mvc;

namespace SchoolMS.Areas.Student.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
