using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Cours.TP2.Misc;

namespace Cours.TP2.Stock
{
    interface IProduit
    {
        int Id { get;  }

        string Designation { get; set; }

        int Quantite { get; set; }

        double PrixUnitaireHt { get; set; }

        Tva.Taux TvaTaux { get; set; }

        string Affiche();

    }
}
