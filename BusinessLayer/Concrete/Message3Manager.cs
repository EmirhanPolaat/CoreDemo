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
    public class Message3Manager : IMessage3Service
    {
        IMessage3Dal _message3Dal;

        public Message3Manager(IMessage3Dal messageDal)
        {
            _message3Dal = messageDal;
        }

        public List<Message3> GetInboxListByWriter(int id)
        {
            return _message3Dal.GetListWithMessageByWriter(id);
        }

        public List<Message3> GetList()
        {
            return _message3Dal.GetListAll();
        }

        public void TAdd(Message3 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message3 t)
        {
            throw new NotImplementedException();
        }

        public Message3 TGetById(int id)
        {
            return _message3Dal.GetByID(id);
        }

        public void TUpdate(Message3 t)
        {
            throw new NotImplementedException();
        }
    }
}
