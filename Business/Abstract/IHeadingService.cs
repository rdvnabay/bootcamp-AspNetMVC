using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHeadingService
    {
        void Add(Heading heading);
        void ChangeStatus(Heading heading);
        void Delete(Heading heading);
        List<Heading> GetAll();
        List<Heading> GetAllById(int categoryId);
        Heading GetById(int headingId);
        void Update(Heading heading);
    }
}
