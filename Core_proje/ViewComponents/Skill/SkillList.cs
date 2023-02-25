using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillmanager = new SkillManager(new EFSkill());

        public IViewComponentResult Invoke()
        {
            var values = skillmanager.GetList();
            return View(values);
        }

    }
}
