using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager =new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var data = aboutManager.GetAll();
            return View(data);
        }

        [HttpPost]
        public ActionResult Add(About about)
        {
            aboutManager.Add(about);
            return RedirectToAction("Index", "About");
        }

        public PartialViewResult PartialAdd()
        {
            return PartialView();
        }
    }
}