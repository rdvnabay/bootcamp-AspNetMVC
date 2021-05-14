using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Web.Mvc;

namespace MvcUI.Areas.AdminPanel.Controllers
{
    public class StatisticsController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            //Görev-1
            ViewBag.ToplamKategoriSayisi = categoryManager.GetAll().Count;

            //Görev-2
            ViewBag.YazilimKategorisindekiBaslikSayisi = headingManager.GetAll(3).Count;
            
            //Görev-3
            ViewBag.YazarAdindaAHarfiOlanYazarSayisi = writerManager.GetAllBYWriterFirstName("a").Count;
            
            //Görev-4
            ViewBag.EnFazlaBasligaSahipKategoriAdi = categoryManager.GetMaxHeadingCountOfCategory().CategoryName;
           
            //Görev-5
            int statusCategoryTrue = categoryManager.GetAll(true).Count;
            int statusCategoryFalse = categoryManager.GetAll(false).Count;
            ViewBag.KategoriTrueVeFalseArasındakiFark = statusCategoryTrue - statusCategoryFalse;
            
            return View();
        }
    }
}