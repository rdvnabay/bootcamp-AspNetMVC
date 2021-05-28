using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContactService
    {
        Contact GetById(int contactId);
        List<Contact> GetAll();
        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
    }
}
