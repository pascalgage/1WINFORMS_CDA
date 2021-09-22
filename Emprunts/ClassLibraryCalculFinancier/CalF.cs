using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculFinancier
{
    public class Calcul
    {
        public static double CalculdeMensualites(double _k, double _tx, int _nm)
        {
            double resultat = 0;

            resultat = _k * (_tx/(1-(Math.Pow(1+_tx,-_nm))));

                return resultat;
        }
    }
}
