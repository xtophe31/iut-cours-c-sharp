using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Cours.MVC.Tuto1.Controllers
{
    public class AvecPartialController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AffichePartial()
        {
            ViewBag.Nom = "controller vue partielle";
            return PartialView("_PartialDepuisController");
        }
    }
}