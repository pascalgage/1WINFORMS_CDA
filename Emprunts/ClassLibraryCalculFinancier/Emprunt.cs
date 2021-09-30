using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ClassLibraryCalculFinancier
{
    public class Emprunt
    {
        //Declaration de l'évènement...
        public delegate void DelegateMensualiteOver(Emprunt sender);
        public event DelegateMensualiteOver lamensualiteestOver;

        public delegate void DelegateMensOK(Emprunt sender);
        public event DelegateMensOK lamensualiteOK;

        //Attributs...
        private string nom;
        private double capital;
        private int remboursementDureeTotale;
        private Frequence remboursementFrequence;
        private double taux;
        //Propriétés...
        public string Nom { get => nom; set => nom = value; }
        public double Capital { get => capital; set => capital = value; }
        public int RemboursementDureeTotale { get => remboursementDureeTotale; set => remboursementDureeTotale = value; }
        public Frequence RemboursementFrequence { get => remboursementFrequence; set => remboursementFrequence = value; }
        public double Taux { get => taux; set => taux = value; }
        //Constructeurs et Méthodes...
        public enum Frequence : int
        {
            Mensuelle=1,
            Bimestrielle=2,
            Trimestrielle=3,
            Semestrielle=6,
            Annuelle=12

        }
        //Constructeur Classique...
        public Emprunt(string _nom,double _capital,int _remboursementDureeTotale, Frequence _remboursementFrequence,double _taux)
        {
            nom = _nom;
            capital = _capital;
            remboursementDureeTotale = _remboursementDureeTotale;
            remboursementFrequence = _remboursementFrequence;
            taux = _taux;
        }
        //Constructeur par défaut par interdépendance...
        public Emprunt()
            : this("", 0, 1, Frequence.Mensuelle, 0.07)
        {

        }
        //Méthodes...
        public int CalculNombreRemboursement()
        {
            return RemboursementDureeTotale / (int)remboursementFrequence;
        }
        public double CalculDesMensualites()
        {
            double nombreDePaiement = (double)CalculNombreRemboursement();
            double tauxEffectif = taux / (12 / (int)remboursementFrequence);
            double resultat = capital * (tauxEffectif / (1 - Math.Pow(1 + tauxEffectif, -nombreDePaiement)));

            if (resultat > 5000)
            {
                if (lamensualiteestOver != null)
                {
                    lamensualiteestOver(this);
                }
            }
            else
            {
                if (lamensualiteOK != null)
                {
                    lamensualiteOK(this);
                }
            }
            

            return Math.Round(resultat, 2);
        }

        public static bool IsvalidK(string _monTextbox)
        {
            return (Regex.Match(_monTextbox, "^[0-9]+([.,]{1}[0-9]{2})?$").Success);
        }



    }
}
