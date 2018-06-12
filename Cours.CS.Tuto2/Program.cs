using System;

namespace Cours.CS.Tuto2
{

    class Program
    {
        #region propriétés et modificateurs -------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    var personneA = new Personne();
        //    personneA.Id = 10; // où est l'erreur
        //    personneA.Nom = "O'Brian";
        //    personneA.Prenom = "Patrick";
        //    personneA.Age = 75;

        //    var personneB = new Personne {Nom = "Saylor", Prenom = "Steven", Age = 80};

        //    Console.WriteLine("A : {0}",personneA.NomPrenom);

        //    // fin
        //    Console.WriteLine(Environment.NewLine);
        //    Console.WriteLine("appuyez sur une touche >");
        //    Console.ReadKey();
        //}

        #endregion

        #region instance, méthodes et polymorphisme -----------------------------------------------

        //static void Main(string[] args)
        //{
        //    var personneA = new Personne("O'Brian", "Patrick", 75);

        //    var personneB = new Personne { Nom = "Saylor", Prenom = "Steven", Age = 80 };

        //    AffichePersonne(personneA);
        //    AffichePersonne(personneB);

        //    Console.WriteLine(Environment.NewLine);
        //    Console.WriteLine("nombre d'instances : {0}", Personne.Instance);

        //    // passage de paramètres
        //    int a = 3;
        //    int b = 2;
        //    int c = 0;
        //    int d = Operations(a, ref b, out c);

        //    Console.WriteLine("a : {0}, b : {1}, c : {2}, d ; {3}", a,b,c,d);


        //    // fin
        //    Console.WriteLine(Environment.NewLine);
        //    Console.WriteLine("appuyez sur une touche >");
        //    Console.ReadKey();
        //}

        //static void AffichePersonne(Personne personne)
        //{
        //    Console.WriteLine("({0}) {1}", personne.Id, personne.NomPrenom);

        //}

        //static int Operations(int a, ref int b, out int c)
        //{
        //    int temp = b;
        //    b += a;

        //    c = a + b;
            
        //    return a*b;
        //}

        #endregion

        #region héritage --------------------------------------------------------------------------

        static void Main(string[] args)
        {
            var etudiant = new Eleve { Nom = "Prince", Prenom = "Martin", Classe = "CM1" };
            var prof = new Enseignant { Nom = "Krapabelle", Prenom = "Edna", Niveau = "Primaire" };

            Console.WriteLine(etudiant.Afficher());
            Console.WriteLine(prof.Afficher());


            // un autre aspect de l'héritage
            Console.WriteLine(EstComplet(etudiant));
            Console.WriteLine(EstComplet(prof));

            // fin
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("appuyez sur une touche >");
            Console.ReadKey();
        }

        static bool EstComplet(Personne personne)
        {
            return ((personne.Nom.Length > 0) && (personne.Prenom.Length > 0));
        }

        #endregion
    }
}
