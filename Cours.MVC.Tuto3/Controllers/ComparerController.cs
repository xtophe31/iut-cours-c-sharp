using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Cours.MVC.Tuto3.Models;
using Cours.MVC.Tuto3.Models.Dal;
using Cours.MVC.Tuto3.Models.Data;
using Random = Cours.Outils.Random;

namespace Cours.MVC.Tuto3.Controllers
{
    public class ComparerController : Controller
    {
        private const int NB_ITERATION = 100;

        // GET: Comparer
        public ActionResult Index()
        {
            var random = new Random();

            var model = new ComparerViewModel
            {
                NbIteration = NB_ITERATION,
                Debut = DateTime.Now
            };

            List<Auteur> auteurs;
            var indexEntity = new List<int>();
            var indexAdo = new List<int>();

            DateTime start;

            #region test EntityDal

            using (var dal = new AuteurEntityDal())
            {
                // ajout
                start = DateTime.Now;
                for (int i = 0; i < NB_ITERATION; i++)
                {
                    var p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                    indexEntity.Add(dal.Add(p.FirstName, p.LastName));
                }
                model.EntityDalInsert = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;
    
                // liste
                start = DateTime.Now;
                auteurs = dal.GetAll();
                model.EntityDalListe = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // parcours
                start = DateTime.Now;
                foreach (int i in indexEntity)
                {
                    Auteur auteur = dal.Read(i);
                }
                model.EntityDalParcours = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // modification
                start = DateTime.Now;
                foreach (int i in indexEntity)
                {
                    var p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                    dal.Update(i, p.FirstName, p.LastName);
                }
                model.EntityDalChange = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // supprime
                start = DateTime.Now;
                foreach (int i in indexEntity)
                {
                    dal.Delete(i);
                }
                model.EntityDalSupprime = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;
            }
            #endregion

            #region AdoDal
            using (var dal = new AuteurAdoDal())
            {
                // ajout
                start = DateTime.Now;
                for (int i = 0; i < NB_ITERATION; i++)
                {
                    var p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                    indexAdo.Add(dal.Add(p.FirstName, p.LastName));
                }
                model.AdoDalInsert = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // liste
                start = DateTime.Now;
                auteurs = dal.GetAll();
                model.AdoDalListe = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // parcours
                start = DateTime.Now;
                foreach (int i in indexAdo)
                {
                    Auteur auteur = dal.Read(i);
                }
                model.AdoDalParcours = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // modification
                start = DateTime.Now;
                foreach (int i in indexAdo)
                {
                    var p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                    dal.Update(i, p.FirstName, p.LastName);
                }
                model.AdoDalChange = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;

                // supprime
                start = DateTime.Now;
                foreach (int i in indexAdo)
                {
                    dal.Delete(i);
                }
                model.AdoDalSupprime = (int)(DateTime.Now.Subtract(start)).TotalMilliseconds;
            }
            #endregion

            model.Fin = DateTime.Now;

            ViewBag.Title = "Comparatif Entity vs ADO";

            return View(model);
        }
    }
}