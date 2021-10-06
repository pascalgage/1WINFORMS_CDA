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
        private Statut etatCourant;

        //Propriétés...
        public string Produit { get => produit; set => produit = value; }
        public int QuantiteDeCaisseDepuisdemarrage { get => quantiteDeCaissedepuisDemarrage; set => quantiteDeCaissedepuisDemarrage = value; }
        public int QuantiteAProduire { get => quantiteAProduire; set => quantiteAProduire = value; }
        public int ProductionParHeure { get => productionParHeure; set => productionParHeure = value; }
        public Statut EtatCourant { get => etatCourant; set => etatCourant = value; }

        //Constructeur classique...
        public Production(string _produit, int _quantiteAProduire, int _productionParHeure)
        {
            produit = _produit;
            quantiteAProduire= _quantiteAProduire;
            quantiteDeCaissedepuisDemarrage = 0;
            productionParHeure = _productionParHeure;
            etatCourant = Statut.NonDemarree;

        }


        public void ProduireUneCaisse()
        {
            //Sert à produire une caisse...
            
            quantiteDeCaissedepuisDemarrage ++;
        }

        public double NbreDeCaisseProduiteAlaSec()
        {
            double resultat=((double)productionParHeure) / 3600;
            return resultat;
        }

        public enum Statut : int
        {
            NonDemarree,
            Demarree,
            Suspendue,
            Terminee
        }

        public void Demarrer()
        {

            etatCourant = Statut.Demarree;
        }
        public void Arreter()
        {
            etatCourant = Statut.Terminee;
        }

        public void MettreEnPause()
        {
            etatCourant = Statut.Suspendue;
        }

        public void ReprendreLaProduction()
        {
            etatCourant = Statut.Demarree;
        }
        
    }
}
