using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cours.MVC.Tuto2.Models.Dal;
using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Controllers
{
    public class AuteurController : Controller
    {
        // GET: Auteur
        public ActionResult Index()
        {
            List<Auteur> liste;
            using (var dal = new AuteurDal())
            {
                liste = dal.GetAll();
            }

            return View(liste);
        }

        public ActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajouter(Auteur auteur)
        {
            using (var dal = new AuteurDal())
            {
                if (dal.Exists(auteur.Nom, auteur.Prenom))
                {
                    ViewBag.MessageErreur = "existe déjà";
                    ModelState.AddModelError("Auteur","existe déjà");
                }

                if (!ModelState.IsValid)
                    return View(auteur);

                dal.Add(auteur.Nom, auteur.Prenom);

                return RedirectToAction("Index");
            }
        }
        //public ActionResult AfficheLivres(int id)
        //{
        //    List<Livre> liste;
        //    using (var dal = new LivreDal())
        //    {
        //        liste = dal.GetAuteur(id);
        //    }

        //    return PartialView(liste);
        //}
    }
}