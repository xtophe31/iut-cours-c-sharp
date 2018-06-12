using System;

namespace Cours.MVC.TP1.Models.Misc
{
    public class Tva
    {
        public const double TAUX_REDUIT = 0.055;
        public const double TAUX_INTERMEDIAIRE = 0.10;
        public const double TAUX_STANDARD = 0.2;
        public enum Taux
        {
            REDUITE,
            INTERMEDIAIRE,
            STANDARD
        }

        public static double Calcule(Taux t, double d)
        {
            double taux;
            switch (t)
            {
                case Taux.REDUITE:
                    taux = TAUX_REDUIT;
                    break;
                case Taux.INTERMEDIAIRE:
                    taux = TAUX_INTERMEDIAIRE;
                    break;
                default:
                    taux = TAUX_STANDARD;
                    break;
            }

            return Math.Round((d * taux),2);
        }
    }
}
