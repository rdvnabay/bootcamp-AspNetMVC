using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContentManager : IContentService
    {
        private readonly IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
           _contentDal = contentDal;
        }
        public void Add(Content content)
        {
            _contentDal.Add(content);
        }

        public void Delete(Content content)
        {
            _contentDal.Delete(content);
        }

        public List<Content> GetAll()
        {
            return _contentDal.GetAll();
        }

        public List<Content> GetAll(int headingId)
        {
            return _contentDal.GetAll(x=>x.HeadingId==headingId);
        }

        public Content GetById(int contentId)
        {
            return _contentDal.Get(x => x.Id == contentId);
        }

        public void Update(Content content)
        {
            _contentDal.Update(content);
        }
    }
}
