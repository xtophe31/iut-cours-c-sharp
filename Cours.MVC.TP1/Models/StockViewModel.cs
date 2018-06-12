using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cours.MVC.TP1.Models.Stock;

namespace Cours.MVC.TP1.Models
{
    public class StockViewModel
    {
        public Stock<IProduit> Stock;

        public int TotalArticles;

        public double TotalValeur;
    }
}