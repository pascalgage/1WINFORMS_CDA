using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTransaction
{
    public class Transaction
    {
        

        //déclaration des attributs...

        private string nom;
        private DateTime date;
        private Decimal montant;
        private int codePostal;

        //Définition des accés aux attributs...
        
        public string Nom { get => nom;  }
        public DateTime Date { get => date; }
        public decimal Montant { get => montant; }
        public int CodePostal { get => codePostal; }
        
        //Constructeur classique...

        public Transaction(string _nom, DateTime _date, decimal _montant, int _codePostal)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.codePostal = _codePostal;
        }
       
    }
}
