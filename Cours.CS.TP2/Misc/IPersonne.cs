using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours.TP2.Misc
{
    interface IPersonne
    {
        string Nom { get; set; }
        string Prenom { get; set; }

        string Affiche();
    }
}
