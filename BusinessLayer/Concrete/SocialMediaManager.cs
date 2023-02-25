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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialmediadal;

        public SocialMediaManager(ISocialMediaDal socialmedia)
        {
            _socialmediadal = socialmedia;
        }

        public List<SocialMedia> GetList()
        {
            return _socialmediadal.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _socialmediadal.Insert(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialmediadal.GetByID(id);
        }

        public void TRemove(SocialMedia t)
        {
            _socialmediadal.Delete(t);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialmediadal.Update(t);
        }
    }
}
