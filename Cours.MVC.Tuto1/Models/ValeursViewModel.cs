using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cours.MVC.Tuto1.Models
{

    public class ValeursViewModel : Personne
    {
        public List<string> Livres { get; private set; }


        public ValeursViewModel()
        {
            Livres = new List<string>();
        }

    }


}