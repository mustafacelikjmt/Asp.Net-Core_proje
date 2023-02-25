using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.Services
{
    public class ServiceList : ViewComponent
    {
        ServiceManager servicemanager = new ServiceManager(new EFService());

        public IViewComponentResult Invoke()
        {
            var values = servicemanager.GetList();
            return View(values);
        }

    }
}
