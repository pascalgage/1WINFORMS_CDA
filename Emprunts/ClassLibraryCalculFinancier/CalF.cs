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

            double exp=Math.Pow((1+_tx/12),-(_nm));
            resultat = _k * ((_tx/12)/(1-(exp)));

                return resultat;
        }
        
        
    }
}
