using NUnit.Framework;

namespace Cours.CS.Tuto3
{
    [TestFixture]
    public class Tests
    {
        [TestFixtureSetUp]

        [Test]
        public void Eleve()
        {
            // Arranger
            var eleve = new Eleve{Nom = "Simpson", Prenom = "Lisa", Classe = "CM1"};

            // Agir
            string actual = eleve.Afficher();

            // Auditer
            Assert.AreEqual("Simpson, Lisa - CM1", actual);
        }
    }
}
