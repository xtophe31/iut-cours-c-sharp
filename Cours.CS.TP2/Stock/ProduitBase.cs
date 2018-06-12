using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cours.TP2.Misc;

namespace Cours.TP2.Stock
{
    abstract class ProduitBase : IProduit
    {
        private static int _idMax;
        private int _quantite;
        private double _prixUnitaireHt;

        public int Id { get; private set; }
        public string Designation { get; set; }


        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = Math.Max(0,value); }
        }

        public double PrixUnitaireHt
        {
            get { return _prixUnitaireHt; }
            set { _prixUnitaireHt = Math.Round(Math.Max(0, value),2); }
        }

        public Tva.Taux TvaTaux { get; set; }
        
        public virtual string Affiche()
        {
            return string.Format("{0}\t\t{1}\t{2} €", Designation, Quantite, PrixUnitaireHt);
        }

        protected ProduitBase()
        {
            Id = _idMax;
            _idMax++;

            Designation = "Nouveau produit";
            Quantite = 0;
            PrixUnitaireHt = 0;
            TvaTaux = Tva.Taux.STANDARD;
        }
    }
}
