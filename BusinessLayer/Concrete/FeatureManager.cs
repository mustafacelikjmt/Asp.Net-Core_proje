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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal _featuredal;

        public FeatureManager(IFeatureDal featuredal)
        {
            _featuredal = featuredal;
        }

        public List<Feature> GetList()
        {
            return _featuredal.GetList();
        }

        public void TAdd(Feature t)
        {
            _featuredal.Insert(t);
        }

        public Feature TGetByID(int id)
        {
            return _featuredal.GetByID(id);
        }

        public void TRemove(Feature t)
        {
            _featuredal.Delete(t);
        }

        public void TUpdate(Feature t)
        {
            _featuredal.Update(t);
        }
    }
}
