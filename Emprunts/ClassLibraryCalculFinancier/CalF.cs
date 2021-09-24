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
            resultat = Math.Round(_k * ((taux)/(1-(exp))),2);

                return resultat;
        }
        
    }
}
