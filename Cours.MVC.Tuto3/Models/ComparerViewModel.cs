using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cours.MVC.Tuto3.Models
{
    public class ComparerViewModel
    {
        public DateTime Debut { get; set; }
        public DateTime Fin { get; set; }

        public int Duree
        {
            get { return (int)(Fin - Debut).TotalMilliseconds; }
        }
        public int NbIteration { get; set; }
        public int EntityDalInsert { get; set; }
        public int AdoDalInsert { get; set; }

        public int EntityDalListe { get; set; }
        public int AdoDalListe { get; set; }

        public int EntityDalParcours { get; set; }
        public int AdoDalParcours { get; set; }

        public int EntityDalChange { get; set; }
        public int AdoDalChange { get; set; }

        public int EntityDalSupprime { get; set; }
        public int AdoDalSupprime { get; set; }
    }
}