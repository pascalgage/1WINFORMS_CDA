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
        //Déclarer le delegate
        public delegate void DelegateProduction(Production sender);
        //Déclarer l'évènement
        public event DelegateProduction CaisseProduite;



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
            quantiteAProduire = _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;
            etatCourant = StatutProd.NonDemarree;
            caisseAvecDefaut = 3;

            threadCourant = new Thread(new ThreadStart(ProduireUneCaisse));

        }




        private void ProduireUneCaisse()
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
                DemarrerThread();
            }
        }

        private void DemarrerThread()
        {
            threadCourant.Start();
        }

        public void Arreter()
        {
            if (etatCourant == StatutProd.Demarree)
            {
                etatCourant = StatutProd.Terminee;

            }

        }

        public void MettreEnPause()
        {
            if (etatCourant == StatutProd.Demarree)
            {
                etatCourant = StatutProd.Suspendue;
                threadCourant.Suspend();
            }
        }

        public void ReprendreLaProduction()
        {
            if (etatCourant == StatutProd.Suspendue)
            {
                etatCourant = StatutProd.Demarree;
                threadCourant.Resume();
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
