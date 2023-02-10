using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.User.Controllers
{
    [Area("User")]
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string p)
        {
            return View();
        }
    }
}
