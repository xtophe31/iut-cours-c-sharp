using System;
using Cours.TP2.Misc;
using Cours.TP2.Stock;

namespace Cours.TP2
{
    class Livre : ProduitBase
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
            return string.Format("{0,-20}\t{1,-20}\t{2,5}\t{3,10}", Designation, Auteur.Affiche(), Quantite, PrixUnitaireHt);
        }
    }
}
