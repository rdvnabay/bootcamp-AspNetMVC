using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dtos
{
    public class HeadingCategoryDto:IDto
    {
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public int MaxValue { get; set; }

    }
}
