using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //Methods
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(x => x.Id == categoryId);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetAll(bool status)
        {
            return _categoryDal.GetAll(x => x.Status == status);
        }

        public HeadingCategoryDto GetMaxHeadingCountOfCategory()
        {
            return _categoryDal.GetMaxHeadingCountOfCategory();
        }
    }
}
