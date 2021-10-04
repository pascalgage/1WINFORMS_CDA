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
        private int quantiteDeCaisseDepuisDemarrage;
        private int quantiteAProduire;
        private int productionParHeure;
        
        //Propriétés...
        
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaisseDepuisDemarrage; }
        
        
       

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaisseDepuisDemarrage = 0;
            productionParHeure = _productionParHeure;

        }


        public void ProduireUneCaisse()
        {
            //Sert à produire une caisse...
            quantiteDeCaisseDepuisDemarrage++;
        }
    }
}
