using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, BlogSiteDbContext>, ICategoryDal
    {
        public HeadingCategoryDto GetMaxHeadingCountOfCategory()
        {
            using (var context = new BlogSiteDbContext())
            {
                var result = from h in context.Headings
                             join c in context.Categories
                             on h.CategoryId equals c.Id
                             group c by c.Name into Group 
                             orderby Group.Count() descending
                             select new HeadingCategoryDto
                             {
                                 CategoryName=Group.Key,
                                 Count=Group.Count()
                             };
                return result.FirstOrDefault();
            }

        }
    } 
}
