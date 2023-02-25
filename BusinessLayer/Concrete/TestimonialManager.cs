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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonial)
        {
            _testimonialdal = testimonial;
        }

        public List<Testimonial> GetList()
        {
            return _testimonialdal.GetList();
        }

        public void TAdd(Testimonial t)
        {
            _testimonialdal.Insert(t);
        }

        public Testimonial TGetByID(int id)
        {
            return _testimonialdal.GetByID(id);
        }

        public void TRemove(Testimonial t)
        {
            _testimonialdal.Delete(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialdal.Update(t);
        }
    }
}
