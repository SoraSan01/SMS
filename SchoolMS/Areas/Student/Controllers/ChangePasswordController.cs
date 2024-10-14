using Microsoft.AspNetCore.Mvc;

namespace SchoolMS.Areas.Student.Controllers
{
    public class ChangePasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
