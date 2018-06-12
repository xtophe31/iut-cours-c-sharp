using System.ComponentModel.DataAnnotations.Schema;

namespace Cours.MVC.Tuto2.Models.Data
{
    //[Table("ClientsExternes")]
    public class Client : PersonneBase
    {
        public string Email { get; set; }

        //[RegularExpression(@"^0[0-9]'9}$", ErrorMessage = @"le format n'est pas bon")]
        //public string Telephone { get; set; }
    }
}