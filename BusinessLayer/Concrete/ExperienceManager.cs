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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experiencedal;

        public ExperienceManager(IExperienceDal experiencedal)
        {
            _experiencedal = experiencedal;
        }

        public List<Experience> GetList()
        {
            return _experiencedal.GetList();
        }

        public void TAdd(Experience t)
        {
            _experiencedal.Insert(t);
        }

        public Experience TGetByID(int id)
        {
            return _experiencedal.GetByID(id);
        }

        public void TRemove(Experience t)
        {
            _experiencedal.Delete(t);
        }

        public void TUpdate(Experience t)
        {
            _experiencedal.Update(t);
        }
    }
}
