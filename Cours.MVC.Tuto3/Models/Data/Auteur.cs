using System.ComponentModel.DataAnnotations;

namespace Cours.MVC.Tuto3.Models.Data
{
    // classe POCO
    // Plain Old C# Object
    // uniquement les propriétés d'un objet
    // ce qui correspond globalement à une table
    public class Auteur
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nom obligatoire")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Prénom indispensable")]
        public string Prenom { get; set; }
    }
}