using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculFinancier
{
    public class Calcul
    {
        public static double CalculdeMensualites(double _k, double _tx, int nbMoisdePeriodicite,int per)
        {
            double resultat = 0;
            double taux = _tx/(12/per);
            double exp=Math.Pow((1+taux),-(nbMoisdePeriodicite));
            resultat = _k * ((taux)/(1-(exp)));

                return resultat;
        }
        
        public static double CalculMens(double capitalEmprunte,double taux,int CalculNbRem)
        {
            double montantRemboursement = Math.Round(capitalEmprunte * (taux / (1 - Math.Pow(1 + taux, -CalculNbRem))), 2);
            return montantRemboursement;
        }





    }
}
