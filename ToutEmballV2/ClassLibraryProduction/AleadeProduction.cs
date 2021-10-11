using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    class AleadeProduction:Random
    {
        private static AleadeProduction alea = null;

        private AleadeProduction()
        {
        }

        public static AleadeProduction Instance()
        {
            if (alea == null)
            {
                alea = new AleadeProduction();
            }
            return alea;
        }

        public int NewAlea(int minValeur, int maxValeur)
        {
            return base.Next(minValeur, maxValeur + 1);
        }

    }
}
