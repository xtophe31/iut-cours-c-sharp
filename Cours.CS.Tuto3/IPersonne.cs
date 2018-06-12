namespace Cours.CS.Tuto3
{
    interface IPersonne
    {
        string Nom { get; set; }
        string Prenom { get; set; }

        string QuiSuisJe();
        string Afficher();
    }
}
