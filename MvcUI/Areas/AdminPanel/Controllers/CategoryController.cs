using Business.Concrete;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //Methods
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                categoryManager.Add(category);
                return RedirectToAction("List", "Category");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View(category);
        }

        public ActionResult Delete(int id)
        {
            var data = categoryManager.GetById(id);
            categoryManager.Delete(data);
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            var model = categoryManager.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryManager.Update(category);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var result = categoryManager.GetAll(); ;
            return View(result);
        }
    }
}