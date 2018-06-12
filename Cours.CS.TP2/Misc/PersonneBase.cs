using System;

using String = Cours.Outils.StringToolsExtensions;

namespace Cours.TP2.Misc
{
    class PersonneBase : IPersonne
    {
        private string _nom;
        private string _prenom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value.ToUpper(); }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = String.ToFirstCharacterUpperCase(value); }
        }

        public PersonneBase(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public string Affiche()
        {
            return System.String.Format("{0}, {1}", Nom, Prenom);
        }


    }
}
