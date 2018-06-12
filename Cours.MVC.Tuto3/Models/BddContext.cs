// il faut importer Entity avec le gestionnaire NuGet

using System.Data.Entity;
using Cours.MVC.Tuto3.Models.Data;

namespace Cours.MVC.Tuto3.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }
    }
}