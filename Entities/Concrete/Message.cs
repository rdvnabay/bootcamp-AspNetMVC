using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Message:IEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
    }
}
