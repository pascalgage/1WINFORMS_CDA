using ClassLibraryCalculFinancier;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Calcul.CalculdeMensualites(150000,0.08,40,120);
            double s = Calcul.CalculMens(150000, 0.08, 40);
        }
    }
}
