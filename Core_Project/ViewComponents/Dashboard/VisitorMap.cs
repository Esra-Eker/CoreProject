using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class VisitorMap :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
