using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EFFeature());

        public IViewComponentResult Invoke()
        {
            var values = featuremanager.GetList();
            return View(values);
        }
    }
}
