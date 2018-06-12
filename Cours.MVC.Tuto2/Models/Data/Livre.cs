using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cours.MVC.Tuto2.Models.Data
{
    public class Livre
    {
        [Required]
        public int Id { get; private set; }

        public int IdAuteur { get; set; }

        public string Nom { get; set; }
    }
}