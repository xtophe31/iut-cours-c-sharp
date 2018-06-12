using System;
using System.Web.Mvc;
using Cours.MVC.Tuto1.Models;

namespace Cours.MVC.Tuto1.Controllers
{
    public class ValeursController : Controller
    {
        public ActionResult AvecViewData()
        {

            // on renseigne dans le dictionnaire ViewData
            ViewData["Texte"] = "dans le ViewData";

            return View();
        }

        //public ActionResult AvecViewBag()
        //{
        //    // on renseigne dans l'objet ViewBag qui est de type dynamic
        //    ViewBag.Texte = "dans le ViewBag";

        //    return View();
        //}

        public ActionResult AvecViewBag()
        {
            // on renseigne dans l'objet ViewBag qui est de type dynamic
            ViewBag.Texte = "dans le ViewBag";
            ViewBag.Valeur = 75;

            return View();
        }

        public ActionResult AvecUnType()
        {
            // ça commence à être interressant
            int valeur = 75;

            return View(valeur);
        }

        public ActionResult AvecUnModele()
        {
            var personne = new Personne
                           {
                               Nom = "Simpson",
                               Prenom = "Homer"
                           };

            return View(personne);
        }

        public ActionResult AvecUnViewModel()
        {
            var model = new ValeursViewModel() {Nom = "Simpson", Prenom = "Bart"};

            model.Livres.Add("MSDN Magazine Décembre");
            model.Livres.Add("Le C# pour les malins");
            model.Livres.Add("Jack et le haricot magique");
            model.Livres.Add("Madame Bovary");
            
            return View(model);
        }

    }
}