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
            maProd = new Production("A",10000,1000);
        }

        private void timerProdA_Tick(object sender, EventArgs e)
        {
            maProd.ProduireUneCaisseA();
            //afficher dans la case de nbre de caisses depuis demarrage le nombre de caisse depart
            textCaissDepDemA.Text = maProd.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarA.Value = (int)maProd.QuantiteDeCaisseDepuisdemarrage;
        }

        private void aToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            //Demarrer le timerProdA....
            timerProdA.Start();
            
        }

        private void timerProdB_Tick(object sender, EventArgs e)
        {
            maProd.ProduireUneCaisseB();
            textCaissDepDemB.Text = maProd.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarB.Value = (int)maProd.QuantiteDeCaisseDepuisdemarrage;
        }


        private void bToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            timerProdB.Start();
        }

        
    }
}
