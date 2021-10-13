using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class AleaDeProduction:Random
    {
        private static AleaDeProduction alea = null;

        private AleaDeProduction()
        {
        }

        public static AleaDeProduction Instance()
        {
            if (alea == null)
            {
                alea = new AleaDeProduction();
            }
            return alea;
        }

        public int NewAlea(int minValeur, int maxValeur)
        {
            return base.Next(minValeur, maxValeur + 1);
        }
    }
}
