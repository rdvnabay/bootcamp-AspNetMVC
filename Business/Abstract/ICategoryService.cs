using Entities.Concrete;
using Entities.Concrete.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int categoryId);
        List<Category> GetAll();
        List<Category> GetAll(bool status);
        HeadingCategoryDto GetMaxHeadingCountOfCategory();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
