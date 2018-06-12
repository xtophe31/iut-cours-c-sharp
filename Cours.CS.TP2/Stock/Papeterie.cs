using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours.TP2.Stock
{
    class Papeterie : ProduitBase
    {
        public enum CategorieEnum
        {
            PAPIER,
            ECRITURE,
            CONSOMMABLE
        }

        public CategorieEnum Categorie { get; set; }

        public Papeterie(CategorieEnum categorie) : base()
        {
            Categorie = categorie;
        }

        public override string Affiche()
        {
            return string.Format("{0,-20}\t{1,-20}\t{2,5}\t{3,5} €", Designation, Categorie.ToString(), Quantite, PrixUnitaireHt);
        }

    }
}
