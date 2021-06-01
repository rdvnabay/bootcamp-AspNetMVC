using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAllReceiveMail()
        {
            return _messageDal.GetAll(x => x.ReceiverMail == "admin@mail.com");
        }

        public List<Message> GetAllSenderMail()
        {
            return _messageDal.GetAll(x => x.SenderMail == "user@mail.com");
        }

        public Message GetById(int messageId)
        {
            throw new NotImplementedException();
        }

        public void Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
