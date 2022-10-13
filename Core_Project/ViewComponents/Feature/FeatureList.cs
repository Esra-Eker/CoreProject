using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        // Views->Shared->Components->FeatureList  Bu classın ismi Components klasörüne ekledğin klasörün ismiyle aynı olmalı.
        
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()  // Burada tanımlanan metotlar hep invoke olarak tanımlanıyor.
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
