namespace Cours.MVC.TP1.Models.Stock
{
    public class Papeterie : ProduitBase
    {
        public enum CategorieEnum
        {
            PAPIER,
            ECRITURE,
            CONSOMMABLE
        }

        public CategorieEnum Categorie { get; set; }

        public Papeterie(CategorieEnum categorie, string designation) : base()
        {
            Designation = designation;
            Categorie = categorie;
        }

        public override string Affiche()
        {
            return string.Format("{0}", Designation);
        }

    }
}
