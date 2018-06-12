using Cours.MVC.TP1.Models.Misc;

namespace Cours.MVC.TP1.Models.Stock
{
    public interface IProduit
    {
        int Id { get;  }

        string Designation { get; set; }

        int Quantite { get; set; }

        double PrixUnitaireHt { get; set; }

        Tva.Taux TvaTaux { get; set; }

        string Affiche();

    }
}
