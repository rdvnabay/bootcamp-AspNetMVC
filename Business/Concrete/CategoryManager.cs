using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryDal efCategoryDal = new EfCategoryDal();
        public List<Category> GetAll()
        {
            return efCategoryDal.GetAll();
        }

        public void Add(Category category)
        {
            efCategoryDal.Add(category);
        }
    }
}
