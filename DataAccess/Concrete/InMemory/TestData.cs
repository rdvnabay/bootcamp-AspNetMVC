using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class TestData
    {
        List<Category> categories = new List<Category>() {
         new Category{ Id=1, Name="Zeynep",Status=false},
            new Category{Id=2,Name="Ömer",Status=true},
            new Category{Id=3, Name="Melek",Status=true},
            new Category{Id=4,Name="Tuğba",Status=false}
        };

        public List<Category> getAll()
        {
            return categories;
        }

        public Category getById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }
        public  void Add(Category category)
        {
            categories.Add(category);
        } 

        public void Delete(int categoryId)
        {
            var result= categories.FirstOrDefault(c => c.Id == categoryId);
            categories.Remove(result);
        }

        public void Update(Category category)
        {
            var updatedCategory = categories.FirstOrDefault(c => c.Id == category.Id);
            updatedCategory.Name = category.Name;
            updatedCategory.Status = category.Status;
        }
    }
}
