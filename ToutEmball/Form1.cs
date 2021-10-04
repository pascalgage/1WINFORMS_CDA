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

namespace ToutEmball
{
    public partial class FormPROD : Form
    {
        private Production maProd;

        public FormPROD()
        {
            InitializeComponent();
            maProd = new Production("A",1000);
        }

        private void timerProdA_Tick(object sender, EventArgs e)
        {
            maProd.ProduireUneCaisse();
            //je veux afficher dans la case de nbre de caisses depuis demarrage le nombre de caisse depart
            textCaissDepDemA.Text = maProd.QuantiteDeCaisseDepuisdemarrage.ToString();
        }

        private void aToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            //Demarrer le timerProdA....
            timerProdA.Start();
            
        }
    }
}
