using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Thread threadCourant;

        //Déclarer le delegate de production de caisse
        public delegate void DelegateProduction(Production sender);
        //Déclarer l'évènement de caisse produite
        public event DelegateProduction CaisseProduite;

        //Déclarer le delegate de production terminée
        public delegate void DelegateFinProduction(Production sender);
        public event DelegateFinProduction ProductionFinie;

        //Déclarer le delegate de changement d'état de la production
        public delegate void DelegateChangementEtat(Production sender);
        //Déclarer l'évènement de changement d'état de la production
        public event DelegateChangementEtat EtatChangeProd;

        //Propriétés...
        public string Produit { get => produit; set => produit = value; }
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaissedepuisDemarrage; set => quantiteDeCaissedepuisDemarrage = value; }
        public int QuantiteAProduire { get => quantiteAProduire; set => quantiteAProduire = value; }
        public int ProductionParHeure { get => productionParHeure; set => productionParHeure = value; }
        public StatutProd EtatCourant { get => etatCourant; }
        public int CaisseAvecDefaut { get => caisseAvecDefaut; set => caisseAvecDefaut = value; }

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire = _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;
            etatCourant = StatutProd.NonDemarree;
            caisseAvecDefaut = 3;

            threadCourant = new Thread(new ThreadStart(ProduireDesCaisses));
            DemarrerThread();

        }
       

        private void ProduireDesCaisses()
        {

            while (quantiteDeCaissedepuisDemarrage < QuantiteAProduire)
            {
                if (etatCourant == StatutProd.Demarree)
                {
                    quantiteDeCaissedepuisDemarrage++;
                    Thread.Sleep(100);
                    //caisse a été produite...
                    CaisseAEteProduite();
                    
                }
               
            }
            etatCourant = StatutProd.Terminee;
            ProdAChangeDEtat();
            ProductionEstFinie();

        }
        private void ProductionEstFinie()
        {
            if (ProductionFinie != null)
            {
                ProductionFinie(this);
            }
        }


        private void CaisseAEteProduite()
        {
            if (CaisseProduite != null)
            {
                CaisseProduite(this);
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
            if ((etatCourant == StatutProd.Suspendue) || (etatCourant == StatutProd.NonDemarree))
            {
                etatCourant = StatutProd.Demarree;
                ProdAChangeDEtat();
                
            }

        }

        private void ProdAChangeDEtat() 
        {
            if (EtatChangeProd != null)
            {
                EtatChangeProd(this);
            }
        }

        private void DemarrerThread()
        {
            threadCourant.Start();
        }

        //public void Arreter()
        //{
        //    if (etatCourant == StatutProd.Demarree)
        //    {
        //        etatCourant = StatutProd.Terminee;
        //        ProdAChangeDEtat();

        //    }

        //}

        public void MettreEnPause()
        {
            if (etatCourant == StatutProd.Demarree)
            {
                etatCourant = StatutProd.Suspendue;
                ProdAChangeDEtat();
                //threadCourant.Suspend();
            }
        }

        public void ReprendreLaProduction()
        {
            if (etatCourant == StatutProd.Suspendue)
            {
                etatCourant = StatutProd.Demarree;
                ProdAChangeDEtat();
                //threadCourant.Resume();
            }
        }

        public void Redemarrer()
        {
            if (etatCourant == StatutProd.Terminee)
            {
                quantiteDeCaissedepuisDemarrage = 0; 
                etatCourant = StatutProd.NonDemarree;
                ProdAChangeDEtat();
                threadCourant = new Thread(new ThreadStart(ProduireDesCaisses));
                DemarrerThread();
            }
        }

        public decimal TauxErreur()
        {
            decimal result;

            int nombreAleatoire = AleaDeProduction.Instance().NewAlea(0, 101);

            result = (((decimal)quantiteDeCaissedepuisDemarrage * (decimal)nombreAleatoire) / 100000);

            return decimal.Round(result, 4);

        }

    }

}
