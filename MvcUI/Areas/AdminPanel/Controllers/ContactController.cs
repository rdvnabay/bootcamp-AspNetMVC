using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            var data = contactManager.GetAll();
            return View(data);
        }

        public ActionResult GetDetail(int id)
        {
            var data = contactManager.GetById(id);
            return View(data);
        }
    }
}