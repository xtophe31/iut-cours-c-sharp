using System;

namespace Cours.CS.Tuto3
{
    class Eleve : IPersonne
    {
        public const string TYPE = "ELEVE";
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Classe { get; set; }
        public string QuiSuisJe()
        {
            return TYPE;
        }

        public string Afficher()
        {
            return String.Format("{0}, {1} - {2}", Nom, Prenom, Classe);
        }
    }
}
