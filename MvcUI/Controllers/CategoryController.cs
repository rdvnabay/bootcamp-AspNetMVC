using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Web.Mvc;

namespace MvcUI.Controllers
{
    public class CategoryController : Controller
    {
      
        //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            //var categories=categoryManager.GetAll();
            return View();
        }
    }
}