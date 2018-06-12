using System.Web.Mvc;

namespace Cours.MVC.Tuto1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            return View();

            // les avantages de la convention
            // cela équivaut à 
            // return View("Index")
        }

        //[ActionName("index")]
        //public ActionResult PourVoir(string id)
        //{
        //    return View();
        //}
        
        //public ActionResult Index(string id)
        //{
        //    if (String.IsNullOrEmpty(id))
        //        return View("Erreur");

        //    return View();
        //}



    }
}