// espaces de nom utilisés

using System;

namespace Cours.CS.Tuto1
{
    internal class Program
    {
        #region premier exemple -------------------------------------------------------------------

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Word !");

            Console.WriteLine("appuyez sur une touche");

            Console.ReadKey();
        }

        #endregion
        
        #region variables, structures et classes --------------------------------------------------

    //    class DemoClass
    //    {
    //        public int Valeur;
    //    }

    //    struct DemoStruct
    //    {
    //        public int Valeur;
    //    }

    //    private static void Main(string[] args)
    //    {
    //        // variable
    //        int i = 1;
    //        int j = i;
    //        i = i+1;

    //        Console.WriteLine(i.GetType().IsValueType);
    //        Console.WriteLine(i.GetType().FullName);
    //        Console.WriteLine(@"i={0}, j={1}", i, j);
    //        Console.WriteLine(Environment.NewLine);

    //        // classe
    //        DemoClass classA = new DemoClass();
    //        classA.Valeur = 1;
    //        DemoClass classB = classA;
    //        classA.Valeur ++;
    //        Console.WriteLine(classA.GetType().IsValueType);
    //        Console.WriteLine(classA.GetType().FullName);
    //        Console.WriteLine(@"classeA={0}, classeB={1}", classA.Valeur, classB.Valeur);
    //        Console.WriteLine(Environment.NewLine);

    //        // structure
    //        DemoStruct structA = new DemoStruct();
    //        structA.Valeur = 1;
    //        DemoStruct structB = structA;
    //        structA.Valeur++;
    //        Console.WriteLine(structA.GetType().IsValueType);
    //        Console.WriteLine(structA.GetType().FullName);
    //        Console.WriteLine(@"structA={0}, classeB={1}", structA.Valeur, structB.Valeur);
    //        Console.WriteLine(Environment.NewLine);

    //        // string
    //        string strA = "Hello";
    //        string strB = strA;
    //        strA += " World";
    //        Console.WriteLine(strA.GetType().IsValueType); // n'est pas une valeur
    //        Console.WriteLine(strA.GetType().FullName);
    //        Console.WriteLine(@"strA={0}, strB={1}", strA, strB); // mais se comporte comme tel
    //        Console.WriteLine(Environment.NewLine);

    //        String strC = "Hello";
    //        String strD = strC;
    //        strC += " Wolrd";
    //        Console.WriteLine(@"strC={0}, strB={1}", strC, strD); // une autre preuve
    //        Console.WriteLine(Environment.NewLine);


    //        // fin
    //        Console.WriteLine("appuyez sur une touche >");
    //        Console.ReadKey();
    //    }

    #endregion

        #region tableaux, listes et énumération ---------------------------------------------------
    
        //class DemoClass
        //{
        //    public int Valeur;
        //}

        //struct DemoStruct
        //{
        //    public int Valeur;
        //}

        //enum TarifSemaine
        //{
        //    Lundi=2,
        //    Mardi=3,
        //    Mercredi=5,
        //    Jeudi=3,
        //    Vendredi=8,
        //    Samedi=10,
        //    Dimanche=8
        //}

        //[Flags]
        //enum Droits
        //{
        //    Aucun = 0x0,
        //    Lecture = 0x1,
        //    Ecriture = 0x2,
        //    Suppression = 0x4,
        //    LectureEcriture = 3,
        //    Tous = 7
        //}

        //private static void Main(string[] args)
        //{
        //    Console.WriteLine(@"Tableaux, listes et énumération");
        //    Console.WriteLine(Environment.NewLine);

        //    // tableau
        //    int[] premiers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        //    //var premiers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        //    //int[] premiers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        //    Console.WriteLine(@"Premiers : 4ème : {0}", premiers[4]);
        //    Console.WriteLine(Environment.NewLine);

        //    // liste
        //    List<int> fibonacci = new List<int>() { 0, 1, 1 };
        //    //var fibonacci = new List<int>(){0,1,1};
        //    fibonacci.Add(2);
        //    fibonacci.Add(3);
        //    fibonacci.Add(8);
        //    fibonacci.Add(13);
        //    fibonacci.Add(21);
        //    Console.WriteLine(@"Fibonaci 5ème : {0}", fibonacci[4]);
        //    Console.WriteLine(Environment.NewLine);

        //    // énumaration
        //    Console.WriteLine(@"Tarif {0}  : {1}", TarifSemaine.Mercredi, (int)TarifSemaine.Mercredi);
        //    var tarifTtc = (double)TarifSemaine.Lundi;
        //    tarifTtc *= 1.2;
        //    Console.WriteLine(@"Tarif Lundi TTC: {0}", tarifTtc);
        //    Console.WriteLine(Environment.NewLine);

        //    // drapeaux
        //    var droits = Droits.Aucun;
        //    droits |= Droits.LectureEcriture;
        //    Console.WriteLine("Ecriture : {0}", ((droits & Droits.Ecriture) == Droits.Ecriture));
        //    Console.WriteLine("Suppression : {0}", ((droits & Droits.Suppression) == Droits.Suppression));

        //    // fin
        //    Console.WriteLine("appuyez sur une touche >");
        //    Console.ReadKey();
        //}

        #endregion

        #region boucles ---------------------------------------------------------------------------

        //private static void Main(string[] args)
        //{
        //    Console.WriteLine(@"Boucles");
        //    Console.WriteLine(Environment.NewLine);

        //    // for
        //    for (int i=0; i<5; i++)
        //    {
        //        Console.WriteLine("i = {0}",i);
        //    }
        //    Console.WriteLine(Environment.NewLine);

        //    // while
        //    int j = 1;
        //    while (j < 100)
        //    {
        //        Console.WriteLine("j = {0}", j);
        //        j *= 2;
        //    }
        //    Console.WriteLine(Environment.NewLine);


        //    // do while
        //    int k = 10;
        //    do
        //    {
        //        Console.WriteLine("k = {0}", k);
        //        k--;
        //    } while (k > 0);
        //    Console.WriteLine(Environment.NewLine);

        //    // foreach
        //    var iListe = new List<int>(){0,1,1,2,3,5,8,13,21};
        //    foreach (int valeur in iListe)
        //    {
        //        Console.WriteLine("valeur {0}", valeur);
        //    }
        //    Console.WriteLine(Environment.NewLine);

        //    // continue
        //    for (int i = 1; i < 10; i++)
        //    {
        //        if (i%2 == 0)
        //            continue;
        //        Console.WriteLine("i = {0}", i);
        //    }
        //    Console.WriteLine(Environment.NewLine);

        //    // break
        //    for (int i = 1; i < 100; i *= 2)
        //    {
        //        if (i == 128)
        //            break;
        //        Console.WriteLine("i = {0}", i);
        //    }
        //    Console.WriteLine(Environment.NewLine);

        //    // fin
        //    Console.WriteLine("appuyez sur une touche >");
        //    Console.ReadKey();
        //}

        #endregion
    }
}
