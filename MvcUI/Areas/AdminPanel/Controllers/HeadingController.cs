using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        public ActionResult Add()
        {
            List<SelectListItem> CategoryList = (from c in categoryManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text=c.Name,
                                                     Value=c.Id.ToString()
                                                 }).ToList();

            List<SelectListItem> WriterList = (from w in writerManager.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = w.FirstName+ " "+w.LastName ,
                                                     Value = w.Id.ToString()
                                                 }).ToList();
            ViewBag.CategoryList = CategoryList;
            ViewBag.WriterList = WriterList;

            return View();
        }

        [HttpPost]
        public ActionResult Add(Heading heading)
        {
            heading.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.Add(heading);
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var model = headingManager.GetAll();
            return View(model);
        }
    }
}