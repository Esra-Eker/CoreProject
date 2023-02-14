using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.User.Controllers
{
    public class DefaultController : Controller
    {
        [Area("User")]
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
