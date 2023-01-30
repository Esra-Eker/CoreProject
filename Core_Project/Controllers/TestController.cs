using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
