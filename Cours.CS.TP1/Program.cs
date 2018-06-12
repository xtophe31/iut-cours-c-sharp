using System;
using System.Collections.Generic;

namespace Cours.CS.TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombres premiers");
            Console.WriteLine("________________");
            Console.WriteLine(Environment.NewLine);

            Console.Write("Saisir la borne : ");
            string lecture = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);

            int borne;
            if (int.TryParse(lecture, out borne)) 
            {
                foreach (int i in EratostheneOptimise(borne))
                {
                    Console.Write("{0} ",i);
                }
            }
            else
            {
                Console.WriteLine("La valeur saisie n'est pas un entier");

            }

            // fin
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("appuyez sur une touche >");
            Console.ReadKey();
        }

        /// <summary>
        /// on parcours un tableau de 2 à n en commencant par barrer les multiples de 2 
        /// aux itérations suivante, on barre les multiples du plus petit entier restant
        /// on optimise en cherchant pas dans les multiples déjà éliminés
        /// et il est inutile de dépasser la racine carré de n
        /// </summary>
        /// <param name="borneMax"></param>
        private static List<int> EratostheneOptimise(int borneMax)
        {
            // a part 2, tous les paris peuvent être supprimé, on divise le stockage par 2
            var dimension = (int) (borneMax/2);
            var grille = new bool[dimension];

            var racineMax = (int) Math.Sqrt(borneMax) + 1;

            // on parcours les impairs
            for (int i = 3; i < racineMax; i += 2)
            {
                if (!grille[i/2])
                {
                    int j = (i*i)/2;
                    // on parcours les multiples
                    while (j < dimension)
                    {
                        grille[j] = true;
                        j += i;
                    }
                }
            }

            var resultat = new List<int> {1, 2};
            for (int i = 1; i < dimension; i++)
            {
                if (!grille[i]) resultat.Add((i*2)+1);
            }

            return resultat;

        }
    }
}
