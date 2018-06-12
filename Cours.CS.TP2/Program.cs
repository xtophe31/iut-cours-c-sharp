using System;
using Cours.TP2;
using Cours.TP2.Stock;

using Random = Cours.Outils.Random;

namespace Cours.CS.TP2
{
    class Program
    {
        private static Stock<IProduit> stock;

        static void Main(string[] args)
        {
            stock = new Stock<IProduit>();

            GenereStockLivre();
            GenereStockPapeterie();

            var stockLivre = stock.Get(typeof (Livre));

            foreach (var produit in stockLivre)
            {
                Console.WriteLine(produit.Affiche());
            }

            Console.WriteLine("Nombre d'articles : {0}/{1}", stockLivre.Count, stock.Count);
            Console.WriteLine("Valeur : {0}/{1}", stockLivre.Valeur(), stock.Valeur());

        }

        static void GenereStockLivre()
        {
            var random = new Random();

            // on fabrique 100 livres au max
            for (int i = 0; i < random.Next(20,100); i++)
            {
                Random.Person p = random.NextPerson(Random.AllowedLanguage.FRENCH);
                string titre = random.NextLoremIpsum(random.Next(2));
                
                var livre = new Livre(titre, p.FirstName, p.LastName)
                            {
                                PrixUnitaireHt = random.Next(1, 200) + random.NextDouble(),
                                Quantite = random.Next(20)
                            };

                stock.Add(livre);
            }
        }


        static void GenereStockPapeterie()
        {
            var random = new Random();

            // on fabrique 100 produits au max
            for (int i = 0; i < random.Next(100); i++)
            {
                string designation = random.NextWord(10);
                var categorie = (Papeterie.CategorieEnum)random.Next(Enum.GetValues(typeof(Papeterie.CategorieEnum)).Length-1);

                var papeterie = new Papeterie(categorie)
                {
                    PrixUnitaireHt = random.Next(1, 200) + random.NextDouble(),
                    Quantite = random.Next(20)
                };

                stock.Add(papeterie);
            }
        }
    }
}
