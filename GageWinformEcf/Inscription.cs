using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GageWinformEcf
{
    public class Inscription
    {
        //déclaration des attributs...
        private string nom;
        private string prenom;
        private DateTime dateentree;
        private DateTime datesortie;
        private string sectionf;

        //Définition des accés aux attributs...
        public string Nom { get => nom;}
        public string Prenom { get => prenom;  }
        public DateTime Dateentree { get => dateentree; }
        public DateTime Datesortie { get => datesortie; }
        public string Sectionf { get => sectionf; }

        //Constructeur classique...
        public Inscription(string _nom, string _prenom, DateTime _Dentree, DateTime _Dsortie, string _section)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.dateentree = _Dentree;
            this.datesortie = _Dsortie;
            this.sectionf = _section;

        }

    }
}
