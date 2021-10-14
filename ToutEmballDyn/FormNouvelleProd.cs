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
    public partial class FormNouvelleProd : Form
    {
        
        
        public string Produit { get => textBoxNomProd.Text; }
        public string QuantiteAprod { get =>textBoxQuantiteAprod.Text ; }
        public string QuantiteParHeure { get => textBoxProductionParHeure.Text; }

        public FormNouvelleProd()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        
    }
}
