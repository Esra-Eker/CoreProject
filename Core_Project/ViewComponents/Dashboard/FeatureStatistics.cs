using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var values = contactManager.TGetList();
            return View();
        }
    }
}
