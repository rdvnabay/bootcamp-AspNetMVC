using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAboutService
    {
        About GetById(int aboutId);
        List<About> GetAll();
        void Add(About about);
        void Delete(About about);
        void Update(About about);
    }
}
