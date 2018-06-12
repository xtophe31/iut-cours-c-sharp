using Cours.MVC.TP1.Models.Misc;

namespace Cours.MVC.TP1.Models.Stock
{
    public class Livre : ProduitBase
    {
        public PersonneBase Auteur { get; set; }

        public string Editeur { get; set; }

        public Livre(string nomLivre, string nomAuteur, string prenomAuteur) : base()
        {
            Designation = nomLivre;
            Auteur = new PersonneBase(nomAuteur, prenomAuteur);

            Editeur = "inconnu";

            TvaTaux = Tva.Taux.REDUITE;
        }

        public override string Affiche()
        {
            return string.Format("{0} ({1})", Designation, Auteur.Affiche());
        }
    }
}
