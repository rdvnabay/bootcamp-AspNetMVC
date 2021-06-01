using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public ActionResult InBox()
        {
            var messages = messageManager.GetAllReceiveMail();
            return View(messages);
        }

        public ActionResult SendBox()
        {
            var messages = messageManager.GetAllSenderMail();
            return View(messages);
        }

        public ActionResult CreateNewMessage()
        {
            return View();
        }
    }
}