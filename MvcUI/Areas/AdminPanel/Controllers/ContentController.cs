using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class ContentController : Controller
    {

        ContentManager contentManager = new ContentManager(new EfContentDal());
        public ActionResult ContentByHeading(int id)
        {
            var model = contentManager.GetAll(id);
            return View(model);
        }
    }
}