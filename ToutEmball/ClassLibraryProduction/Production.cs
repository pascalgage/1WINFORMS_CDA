using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class Production
    {
        //Attributs....
        private string produit;
        private double quantiteDeCaissedepuisDemarrage;
        private int quantiteAProduire;
        private int productionParHeure;
        
        //Propriétés...
        
        public double QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaissedepuisDemarrage; }
        




        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;

        }


        public void ProduireUneCaisse()
        {
            //Sert à produire une caisse...
            
            quantiteDeCaissedepuisDemarrage ++;
        }

        
    }
}
