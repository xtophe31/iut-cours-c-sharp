using System.Linq;
using System.Web.Mvc;
using Cours.MVC.TP1.Models;
using Cours.MVC.TP1.Models.Stock;

namespace Cours.MVC.TP1.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult Index(string filtre)
        {
            var stock = (Stock<IProduit>) Session["Stock"];

            var extrait = new StockViewModel {TotalArticles = stock.Count, TotalValeur = stock.Valeur()};


            if (filtre != null)
            {
                switch (filtre)
                {
                    case "Livre":
                        extrait.Stock = stock.Get(typeof (Livre));
                        break;
                    case "Papeterie":
                        extrait.Stock = stock.Get(typeof (Papeterie));
                        break;
                    default:
                        extrait.Stock = stock;
                        break;
                }
            }
            else
                extrait.Stock = stock;

            return View(extrait);
        }
    }
}