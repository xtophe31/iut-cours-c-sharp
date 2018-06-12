using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using Cours.MVC.Tuto2.Models;
using Cours.MVC.Tuto2.Models.Dal;
using Cours.MVC.Tuto2.Models.Data;
using Random = Cours.Outils.Random;

namespace Cours.MVC.Tuto2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //IDatabaseInitializer <BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            //Database.SetInitializer(init);
            //init.InitializeDatabase(new BddContext());

            //GenerateAuteurs();

            //GenerateLivres();
        }

        private void GenerateAuteurs()
        {
            var random = new Random();

            var dal = new AuteurDal();

            // on fabrique 100 livres au max
            for (int i = 0; i < random.Next(10, 20); i++)
            {
                Random.Person p = random.NextPerson(Random.AllowedLanguage.FRENCH);

                dal.Add(p.FirstName, p.LastName);
            }
        }
    }
}
