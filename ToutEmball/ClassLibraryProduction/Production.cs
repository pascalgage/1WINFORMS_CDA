﻿using System;
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
        private int quantiteDeCaissedepuisDemarrage;
        private int quantiteAProduire;
        private int productionParHeure;
        private StatutProd etatCourant;

        //Propriétés...
        public string Produit { get => produit; set => produit = value; }
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaissedepuisDemarrage; set => quantiteDeCaissedepuisDemarrage = value; }
        public int QuantiteAProduire { get => quantiteAProduire; set => quantiteAProduire = value; }
        public int ProductionParHeure { get => productionParHeure; set => productionParHeure = value; }
        public StatutProd EtatCourant { get => etatCourant; set => etatCourant = value; }

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;
            etatCourant = StatutProd.NonDemarree;

        }


        public void ProduireUneCaisse()
        {
            //Sert à produire une caisse...
            
            quantiteDeCaissedepuisDemarrage ++;

            //verifier qu'on atteint pas le maximum
            if (quantiteDeCaissedepuisDemarrage == quantiteAProduire)
            {
                etatCourant = StatutProd.Terminee;
            }

        }


        public enum StatutProd : int
        {
            NonDemarree,
            Demarree,
            Suspendue,
            Terminee
        }

        public void Demarrer()
        {
            if ((etatCourant == StatutProd.Suspendue)||(etatCourant == StatutProd.NonDemarree))
            { 
                etatCourant = StatutProd.Demarree;
            }
        }
        public void Arreter()
        {
            etatCourant = StatutProd.Terminee;
        }

        public void MettreEnPause()
        {
            if (etatCourant == StatutProd.Demarree)
            { 
                etatCourant = StatutProd.Suspendue;
            }
        }

        public void ReprendreLaProduction()
        {
            if (etatCourant == StatutProd.Suspendue)
            {
                etatCourant = StatutProd.Demarree;
            }
        }
        
    }
}
