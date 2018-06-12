using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Cours.MVC.TP1.Models.Stock;
using Random = Cours.Outils.Random;

namespace Cours.MVC.TP1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }

        protected void Session_Start()
        {
            var stock = new Stock<IProduit>();

            GenereStockLivre(stock);
            GenereStockPapeterie(stock);

            Session["Stock"] = stock;
        }

        static void GenereStockLivre(Stock<IProduit> stock)
        {
            var random = new Outils.Random();

            // on fabrique 100 livres au max
            for (int i = 0; i < random.Next(20, 100); i++)
            {
                Random.Person p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                string titre = random.NextLoremIpsum(random.Next(2));

                var livre = new Livre(titre, p.FirstName, p.LastName)
                {
                    PrixUnitaireHt = random.Next(1, 200) + random.NextDouble(),
                    Quantite = random.Next(20)
                };

                stock.Add(livre);
            }
        }


        static void GenereStockPapeterie(Stock<IProduit> stock)
        {
            var random = new Random();

            // on fabrique 100 produits au max
            for (int i = 0; i < random.Next(100); i++)
            {
                string designation = random.NextWord(10);
                var categorie = (Papeterie.CategorieEnum)random.Next(Enum.GetValues(typeof(Papeterie.CategorieEnum)).Length - 1);

                var papeterie = new Papeterie(categorie, designation)
                {
                    PrixUnitaireHt = random.Next(1, 200) + random.NextDouble(),
                    Quantite = random.Next(20)
                };

                stock.Add(papeterie);
            }
        }
    }
}
