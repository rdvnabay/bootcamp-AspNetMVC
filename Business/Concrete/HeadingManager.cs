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
    public class HeadingManager : IHeadingService
    {
        private IHeadingDal _headingDal;
        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void Add(Heading heading)
        {
            _headingDal.Add(heading);
        }

        public void Delete(Heading heading)
        {
            _headingDal.Delete(heading);
        }

        public List<Heading> GetAll()
        {
            return _headingDal.GetAll();
        }

        public List<Heading> GetAllById(int categoryId)
        {
           return _headingDal.GetAll(x=>x.CategoryId== categoryId);
        }

        public Heading GetById(int headingId)
        {
            return _headingDal.Get(x => x.Id == headingId);
        }

        public void Update(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void ChangeStatus(Heading heading)
        {
            heading.Status = false;
            _headingDal.Update(heading);
        }
    }
}
