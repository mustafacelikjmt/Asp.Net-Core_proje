using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public List<Skill> GetList()
        {
            return _skilldal.GetList();
        }

        public void TAdd(Skill t)
        {
            _skilldal.Insert(t);
        }

        public Skill TGetByID(int id)
        {
            return _skilldal.GetByID(id);
        }

        public void TRemove(Skill t)
        {
            _skilldal.Delete(t);
        }

        public void TUpdate(Skill t)
        {
            _skilldal.Update(t);
        }
    }
}
