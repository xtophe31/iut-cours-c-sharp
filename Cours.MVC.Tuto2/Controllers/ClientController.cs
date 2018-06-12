using System.Web.Mvc;
using Cours.MVC.Tuto2.Models.Dal;
using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Models
{
    public class ClientController : Controller
    {
        public ActionResult Index()
        {
            // ce serait pas mal d'afficher les clients

            return View();
        }

        public ActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajouter(Client client)
        {
            using (var dal = new ClientDal())
            {
                if (dal.Existe(client.Nom, client.Prenom))
                {
                    ViewBag.MessageErreur = "Ce client existe déjà";
                    ModelState.AddModelError("Client","Ce client existe déjà");
                }
                if (!ModelState.IsValid)
                {
                    return View(client);
                }

                dal.Add(client.Nom, client.Prenom, client.Email);

                return RedirectToAction("Index");
            }
        }

    }
}