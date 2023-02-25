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
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal message)
        {
            _messagedal = message;
        }

        public List<Message> GetList()
        {
            return _messagedal.GetList();
        }

        public void TAdd(Message t)
        {
            _messagedal.Insert(t);
        }

        public Message TGetByID(int id)
        {
            return _messagedal.GetByID(id);
        }

        public void TRemove(Message t)
        {
            _messagedal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _messagedal.Update(t);
        }
    }
}
