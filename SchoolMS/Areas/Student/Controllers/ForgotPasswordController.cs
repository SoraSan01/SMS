using Microsoft.AspNetCore.Mvc;

namespace SchoolMS.Areas.Student.Controllers
{
    public class ForgotPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
