using System;

namespace Cours.CS.Tuto2
{
    #region propriétés et modificateurs -----------------------------------------------------------

    //class Personne
    //{
    //    int Id;

    //    public string Nom;

    //    private int _age;

    //    public int Age
    //    {
    //        get { return _age; }

    //        set
    //        {
    //            _age = Math.Max(0,value);
    //        }
    //    }

    //    public string Prenom { get; set; }

    //    public string NomPrenom {
    //        get { return String.Format("{0}, {1}", Nom, Prenom); }
    //    }

    //    public void Vielli(int deCombien)
    //    {
    //        Age = Age + deCombien;
    //    }

    //    public bool IsMajeur()
    //    {
    //        return (Age >= 18);
    //    }

    //}

    #endregion

    #region instance, méthodes et polymorphisme ---------------------------------------------------

    //class Personne
    //{
    //    // propriétés statiques
    //    public static int Instance { get; private set; }

    //    private static int _lastId;

    //    // propriétés de l'instance
    //    public int Id { get; private set; }

    //    public string Nom { get; set; }
    //    public string Prenom { get; set; }

    //    private int _age;
    //    public int Age
    //    {
    //        get { return _age; }

    //        set
    //        {
    //            _age = Math.Max(0, value);
    //        }
    //    }

    //    public string NomPrenom
    //    {
    //        get { return String.Format("{0}, {1}", Nom, Prenom); }
    //    }

    //    // constructeur et destructeur
    //    public Personne()
    //    {
    //        Instance++;
    //        Id = _lastId;
    //        _lastId++;
    //    }

    //    public Personne(string nom, string prenom, int age)
    //        : this()
    //    {
    //        Nom = nom;
    //        Prenom = prenom;
    //        Age = age;
    //    }

    //    // exemple de polymorphisme
    //    public void Vielli(int deCombien)
    //    {
    //        Age = Age + deCombien;
    //    }

    //    public void Vielli()
    //    {
    //        Vielli(1);
    //    }

    //    // générateur plutot que constructeur
    //    // on passe le constructeur en private
    //    public static Personne Generateur(string nom, string prenom, int age)
    //    {
    //        if (Instance >= 10) return null;

    //        return new Personne{Nom = nom, Prenom = prenom, Age = age};
    //    }

    //}

    #endregion

    #region héritage ------------------------------------------------------------------------------

    public class Personne
    {

        // propriétés de l'instance

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string Afficher()
        {
            return String.Format("{0}, {1}", Nom, Prenom);
        }

        public virtual string QuiSuisJe()
        {
            return "je suis une personne";
        }

    }

    public class Eleve : Personne
    {
        public string Classe { get; set; }

        public override string QuiSuisJe()
        {
            return base.QuiSuisJe() + " et je suis un éléve";
        }
    }

    public class Enseignant : Personne
    {
        public string Niveau { get; set; }

        // on substitue la méthode de la classe de base
        // avec new on masque la méthode originale (comportement par défaut)
        public new string Afficher()
        {
            return String.Format("{0}, {1} - {2}", Nom, Prenom, Niveau);
        }

        public override string QuiSuisJe()
        {
            return base.QuiSuisJe() + " et je suis un enseignant";
        }
    }

    #endregion
}
