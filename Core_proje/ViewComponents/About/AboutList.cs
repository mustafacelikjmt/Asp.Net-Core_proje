using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutmanager = new AboutManager(new EFAbout());

        public IViewComponentResult Invoke()
        {
            var values = aboutmanager.GetList();
            return View(values);
        }
    }
}
