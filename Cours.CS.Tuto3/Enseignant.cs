using System;

namespace Cours.CS.Tuto3
{
    class Enseignant : PersonneBase, IPersonne
    {
        public const string TYPE = "ENSEIGNANT";

        public string Niveau { get; set; }

        public override string QuiSuisJe()
        {
            return TYPE;
        }

        public override string Afficher()
        {
            return String.Format("{0}, {1} - {2}", Nom, Prenom, Niveau);
        }
    }
}
