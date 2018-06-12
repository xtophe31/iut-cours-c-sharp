using System.Web.Mvc;

namespace Cours.MVC.Tuto1.Controllers
{
    public class AvecLayoutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult SansLesMains()
        //{
        //    return View();
        //}

        public ActionResult AvecSections()
        {
            return View();
        }
    }
}