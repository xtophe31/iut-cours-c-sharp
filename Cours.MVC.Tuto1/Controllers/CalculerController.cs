using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cours.MVC.Tuto1.Controllers
{
    public class CalculerController : Controller
    {
        public string Ajouter(int param1, int param2)
        {
            return (param1 + param2).ToString();
        }

        public string Soustraire(int param1, int param2)
        {
            return (param1 - param2).ToString();
        }

    }
}