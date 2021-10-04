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
        private int quantiteDeCaisseDepuisdemarrage;
        private int quantiteAProduire;
        private int tempsEnMinute;
        
        //Propriétés...
        
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaisseDepuisdemarrage; }
        
        
       

        //Constructeur par défaut...
        public Production()
            :this("A", 20,10000, 120)
        {

        }
        //Constructeur classique...
        public Production(string _produit, int _quantiteDeCaisseDepuisdemarrage, int _quantiteAProduire, int _tempsEnMinute)
        {
            this.produit = _produit;
            this.quantiteDeCaisseDepuisdemarrage = _quantiteDeCaisseDepuisdemarrage;
            this.quantiteAProduire= _quantiteAProduire;
            this.tempsEnMinute = _tempsEnMinute;
            
        }
    }
}
