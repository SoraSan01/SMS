using Microsoft.AspNetCore.Mvc;

namespace SchoolMS.Areas.Student.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
