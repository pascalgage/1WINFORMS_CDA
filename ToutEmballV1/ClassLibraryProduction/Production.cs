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
        private int quantiteDeCaissedepuisDemarrage;
        private int quantiteAProduire;
        private int productionParHeure;
        private StatutProd etatCourant;
        private int caisseAvecDefaut;

        //Propriétés...
        public string Produit { get => produit; set => produit = value; }
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaissedepuisDemarrage; set => quantiteDeCaissedepuisDemarrage = value; }
        public int QuantiteAProduire { get => quantiteAProduire; set => quantiteAProduire = value; }
        public int ProductionParHeure { get => productionParHeure; set => productionParHeure = value; }
        public StatutProd EtatCourant { get => etatCourant; set => etatCourant = value; }
        public int CaisseAvecDefaut { get => caisseAvecDefaut; set => caisseAvecDefaut = value; }

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;
            etatCourant = StatutProd.NonDemarree;
            caisseAvecDefaut = 3;

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
            if (etatCourant == StatutProd.Demarree)
            {
                etatCourant = StatutProd.Suspendue;
            }
            
            
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




        public decimal TauxErreur()
        {
            decimal result;

            int nombreAleatoire = AleadeProduction.Instance().NewAlea(0, 101);

            result = (((decimal)quantiteDeCaissedepuisDemarrage * (decimal)nombreAleatoire) / 100000);

            return decimal.Round(result,4);
            
        }
        
    }
}
