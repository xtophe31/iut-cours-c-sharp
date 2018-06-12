using System.Collections.Generic;
using System.Linq;
using Cours.TP2.Stock;

namespace Cours.TP2
{
    class Stock<T> : List<T> where T : IProduit
    {

        public double Valeur()
        {
            return this.Sum(p => (p.Quantite * p.PrixUnitaireHt));
        }

        public Stock<T> Get(System.Type type)
        {
            var stock = new Stock<T>();
            
            stock.AddRange(this.Where(p => (p.GetType() == type)).ToList());

            return stock;
        }
    }
}
