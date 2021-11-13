using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GageWinformEcf
{
    public partial class AffInscription : Form
    {
        public AffInscription()
        {
            InitializeComponent();
        }

        public AffInscription(string nom, string prenom, DateTime dateentree, DateTime datesortie, string section)
        {
            InitializeComponent();
            this.label1.Text = nom;
            this.label2.Text = prenom;
            this.label3.Text = dateentree.ToString();
            this.label4.Text = datesortie.ToString();
            this.label5.Text = section;
            this.BackColor = Color.Green;
        }

        public AffInscription(Inscription _inscription)
        : this(_inscription.Nom, _inscription.Prenom, _inscription.Dateentree, _inscription.Datesortie, _inscription.Sectionf)
        {

        }
        
    }
}
