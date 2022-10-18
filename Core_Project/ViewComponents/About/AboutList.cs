using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()  // Burada tanımlanan metotlar hep invoke olarak tanımlanıyor.
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
