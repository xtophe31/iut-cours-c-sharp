using System;

namespace Cours.CS.Tuto3
{
    class PersonneBase : IPersonne
    {
        public const string TYPE = "PERSONNE";
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual string QuiSuisJe()
        {
            return TYPE;
        }

        public virtual string Afficher()
        {
            return String.Format("{0}, {1}", Nom, Prenom);
        }
    }
}
