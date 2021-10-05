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
        private double quantiteDeCaisseDepuisDemarrage;
        private int quantiteAProduire;
        private int productionParHeure;
        
        //Propriétés...
        
        public double QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaisseDepuisDemarrage; }
        
        
       

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaisseDepuisDemarrage = 0;
            productionParHeure = _productionParHeure;

        }


        public void ProduireUneCaisseA()
        {
            //Sert à produire une caisse...
            double i = 1;
            quantiteDeCaisseDepuisDemarrage += i;
        }

        public void ProduireUneCaisseB()
        {
            double i = 1;
            quantiteDeCaisseDepuisDemarrage += i;
        }
        public void ProduireUneCaisseC()
        {
            double i = 2.77;
            quantiteDeCaisseDepuisDemarrage += i;
        }
    }
}
