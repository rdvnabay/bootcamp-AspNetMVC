using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        Message GetById(int messageId);
        List<Message> GetAllSenderMail();
        List<Message> GetAllReceiveMail();
        void Add(Message message);
        void Delete(Message message);
        void Update(Message message);
    }
}
