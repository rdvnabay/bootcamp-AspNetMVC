using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        //TestData testData = new TestData();
        
        public ActionResult Index()
        {
            var result = categoryManager.GetAll(); ;
            return View(result);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("Index", "Category");
        }
    }
}