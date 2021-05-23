using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContentService
    {
        Content GetById(int contentId);
        List<Content> GetAll();
        List<Content> GetAll(int headingId);
        void Add(Content content);
        void Delete(Content content);
        void Update(Content content);
    }
}
