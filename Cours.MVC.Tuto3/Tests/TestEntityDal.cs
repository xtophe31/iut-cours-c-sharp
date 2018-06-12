using System.Collections.Generic;
using System.Data.Entity;
using Cours.MVC.Tuto3.Models;
using Cours.MVC.Tuto3.Models.Dal;
using Cours.MVC.Tuto3.Models.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cours.MVC.Tuto3.Tests
{
    [TestClass]
    public class TestEntityDal
    {
        [TestInitialize]
        public void AvantLesTest()
        {
            IDatabaseInitializer<BddContext> init = new DropCreateDatabaseAlways<BddContext>();
            Database.SetInitializer(init);
            init.InitializeDatabase(new BddContext());
        }

        [TestMethod]
        public void Auteur_Add()
        {
            var auteur = new Auteur {Nom = "O'Brian", Prenom = "Patrick"};

            using (var dal = new AuteurEntityDal())
            {
                dal.Add(auteur.Nom, auteur.Prenom);

                List<Auteur> auteurs = dal.GetAll();

                Assert.IsNotNull(auteurs);

                Assert.AreEqual(1, auteurs.Count);

                Assert.AreEqual(auteur.Nom, auteurs[0].Nom);
                Assert.AreEqual(auteur.Prenom, auteurs[0].Prenom);
            }
        }

        [TestMethod]
        public void Auteur_DeleteAll()
        {
            using (var dal = new AuteurEntityDal())
            {
                dal.DeleteAll();

                Assert.AreEqual(0, dal.GetAll().Count);
            }
        }

    }

}