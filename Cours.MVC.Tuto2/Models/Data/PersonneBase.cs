using System.ComponentModel.DataAnnotations;

namespace Cours.MVC.Tuto2.Models.Data
{
    // classe POCO
    // Plain Old C# Object
    // uniquement les propriétés d'un objet
    // ce qui correspond globalement à une table
    public class PersonneBase
    {
        public int Id { get; set; }

        [Required, MinLength(5), MaxLength(80)]
        public string Nom { get; set; }

        public string Prenom { get; set; }
    }
}