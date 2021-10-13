using ClassLibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmballDyn
{
    public partial class CreationProd : Form
    {
        private Production uneProd;

        private string produit;
        private int quantiteAprod;
        private int quantiteParHeure;

        public Production UneProd { get => uneProd;  }

        

        public CreationProd()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            uneProd = new Production(textBoxNomProd.Text, Convert.ToInt32(textBoxQuantiteAprod.Text), Convert.ToInt32(textBoxProductionParHeure.Text));
            
        }

        
    }
}
