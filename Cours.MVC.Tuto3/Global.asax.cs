using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Cours.MVC.Tuto3.Models;
using Cours.MVC.Tuto3.Models.Dal;

using Random = Cours.Outils.Random;

namespace Cours.MVC.Tuto3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            //Database.SetInitializer(init);
            //init.InitializeDatabase(new BddContext());

            //GenerateAuteurs();
        }

        private void GenerateAuteurs()
        {
            var random = new Random();

            var dal = new AuteurEntityDal();

            // on fabrique 100 livres au max
            for (int i = 0; i < random.Next(10, 20); i++)
            {
                Random.Person p = random.NextPerson(Random.AllowedLanguage.FRENCH);

                dal.Add(p.FirstName, p.LastName);
            }
        }
    }
}
