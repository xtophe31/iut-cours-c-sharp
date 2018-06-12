using System.Collections.Generic;
using System.Linq;

namespace Cours.CS.Tuto3
{
    class Ecole<T> where T: IPersonne
    {
        public List<T> Membres;

        public Ecole()
        {
            Membres = new List<T>();
        }

        public int CompteEleves()
        {
            int resultats = 0;

            foreach (T membre in Membres)
            {
                if (membre.QuiSuisJe() == Eleve.TYPE) resultats++;
            }

            return resultats;
        }

        // la même chose en LINQ
        public int CompteEnseignants()
        {
            return Membres.Count(membre => membre.QuiSuisJe() == Enseignant.TYPE);
        }
    }
}
