using Microsoft.AspNetCore.Mvc;

namespace SchoolMS.Areas.Student.Controllers
{
    public class EnrollController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
