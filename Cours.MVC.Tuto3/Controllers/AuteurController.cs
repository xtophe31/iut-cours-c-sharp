using System.Collections.Generic;
using System.Web.Mvc;
using Cours.MVC.Tuto3.Models.Dal;
using Cours.MVC.Tuto3.Models.Data;

namespace Cours.MVC.Tuto3.Controllers
{
    public class AuteurController : Controller
    {
        // GET: Auteur
        public ActionResult Index()
        {
            List<Auteur> liste;
            using (var dal = new AuteurEntityDal())
            {
                liste = dal.GetAll();
            }

            ViewBag.Title = "Liste des auteurs";

            return View(liste);
        }

        public ActionResult Ajouter()
        {
            ViewBag.Title = "Ajouter un auteur";

            return View();
        }

        [HttpPost]
        public ActionResult Ajouter(Auteur auteur)
        {
            ViewBag.Title = "Ajouter un auteur";

            using (var dal = new AuteurEntityDal())
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