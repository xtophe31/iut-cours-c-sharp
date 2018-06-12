// il faut importer Entity avec le gestionnaire NuGet
using System.Data.Entity;

using Cours.MVC.Tuto2.Models.Data;

namespace Cours.MVC.Tuto2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Livre> Livres { get; set; } 
    }
}