using System.Collections.Generic;
using System.Data.Entity;
using Cours.MVC.Tuto2.Models;
using Cours.MVC.Tuto2.Models.Dal;
using Cours.MVC.Tuto2.Models.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cours.MVC.Tuto2.Tests
{
    [TestClass]
    public class TestDal
    {
        [TestInitialize]
        public void AvantLesTest()
        {
            IDatabaseInitializer<BddContext> init = 
                new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
        }

        [TestMethod]
        public void Auteur_Add()
        {
            var auteur = new Auteur {Nom = "O'Brian", Prenom = "Patrick"};

            using (var dal = new AuteurDal())
            {
                dal.Add(auteur.Nom, auteur.Prenom);

                List<Auteur> auteurs = dal.GetAll();

                Assert.IsNotNull(auteurs);

                Assert.AreEqual(1, auteurs.Count);

                Assert.AreEqual(auteur.Nom, auteurs[0].Nom);
                Assert.AreEqual(auteur.Prenom, auteurs[0].Prenom);
            }
        }

        //[TestMethod]
        //public void Auteur_DeleteAll()
        //{
        //    using (var dal = new AuteurDal())
        //    {
        //        dal.DeleteAll();

        //        Assert.AreEqual(0,dal.GetAll().Count);
        //    }
        //}


        //[TestMethod]
        //public void Client_Add()
        //{
        //    var element = new Client { Nom = "SIMPSON", Prenom = "Lisa", Email = "lisa@simpson.tv"};

        //    using (var dal = new ClientDal())
        //    {
        //        dal.Add(element.Nom, element.Prenom, element.Email);

        //        List<Client> clients = dal.GetAll();

        //        Assert.IsNotNull(clients);

        //        Assert.AreEqual(1, clients.Count);

        //        Assert.AreEqual(element.Nom, clients[0].Nom);
        //        Assert.AreEqual(element.Prenom, clients[0].Prenom);
        //        Assert.AreEqual(element.Email, clients[0].Email);
        //    }
        //}
    }

}