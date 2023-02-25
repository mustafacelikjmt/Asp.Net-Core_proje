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
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public List<Contact> GetList()
        {
            return _contactdal.GetList();
        }

        public void TAdd(Contact t)
        {
            _contactdal.Insert(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactdal.GetByID(id);
        }

        public void TRemove(Contact t)
        {
            _contactdal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
            _contactdal.Update(t);
        }
    }
}
