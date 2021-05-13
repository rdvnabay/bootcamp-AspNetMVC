using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        HeadingCategoryDto GetMaxHeadingCountOfCategory();
    }
}
