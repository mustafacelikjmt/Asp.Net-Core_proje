using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        public PortfolioManager portfoloiomanager = new PortfolioManager(new EFPortfolio());

        public IViewComponentResult Invoke()
        {
            var values = portfoloiomanager.GetList();
            return View(values);
        }

    }
}
