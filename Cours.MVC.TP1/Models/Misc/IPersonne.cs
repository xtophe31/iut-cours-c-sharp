namespace Cours.MVC.TP1.Models.Misc
{
    public interface IPersonne
    {
        string Nom { get; set; }
        string Prenom { get; set; }

        string Affiche();
    }
}
