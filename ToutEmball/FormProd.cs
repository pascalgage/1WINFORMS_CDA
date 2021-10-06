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
        private Production maProdA;
        private Production maProdB;
        private Production maProdC;

        public FormPROD()
        {
            InitializeComponent();
            maProdA = new Production("A",10000,1000);
            maProdB = new Production("B", 25000, 5000);
            maProdC = new Production("C", 120000, 10000);

        }
        //Commencer la production....

        private void timerProdA_Tick(object sender, EventArgs e)
        {
            maProdA.ProduireUneCaisse();
            
            //afficher dans la case de nbre de caisses depuis demarrage le nombre de caisse depart
            textCaissDepDemA.Text = maProdA.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarA.Value = maProdA.QuantiteDeCaisseDepuisdemarrage;
        }

        private void aToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            //Demarrer le timerProdA....
            maProdA.Demarrer();
            if (maProdA.EtatCourant == Production.Statut.Demarree)
            {
                timerProdA.Start();
            }
            
        }

        private void timerProdB_Tick(object sender, EventArgs e)
        {
            maProdB.ProduireUneCaisse();
            textCaissDepDemB.Text = maProdB.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarB.Value = maProdB.QuantiteDeCaisseDepuisdemarrage;
        }


        private void bToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            maProdB.Demarrer();
            if(maProdB.EtatCourant == Production.Statut.Demarree)
            {
                timerProdB.Start();
            }
            
        }

        private void timerProdC_Tick(object sender, EventArgs e)
        {
            maProdC.ProduireUneCaisse();
            textCaissDepDemC.Text = maProdC.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarC.Value = maProdC.QuantiteDeCaisseDepuisdemarrage;
        }

        private void cToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            maProdC.Demarrer();
            if(maProdC.EtatCourant == Production.Statut.Demarree)
            {
                timerProdC.Start();
            }
        }

        //Arrêter Production...
        private void aToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdA.Arreter();
            if (maProdA.EtatCourant == Production.Statut.Terminee)
            {
                timerProdA.Stop();
                
            }
        }

        private void bToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdB.Arreter();
            if (maProdB.EtatCourant == Production.Statut.Terminee)
            {
                timerProdB.Stop();
            }
            
        }

        private void cToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdC.Arreter();
            if (maProdC.EtatCourant == Production.Statut.Terminee)
            {
                timerProdC.Stop();
            }
            
        }
        //Reprendre la production....
        private void aToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdA.ReprendreLaProduction();
            if (maProdA.EtatCourant == Production.Statut.Demarree)
            {
                timerProdA.Start();
            }
        }

        private void bToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdB.ReprendreLaProduction();
            if (maProdB.EtatCourant == Production.Statut.Demarree)
            {
                timerProdB.Start();
            }
        }

        private void cToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdC.ReprendreLaProduction();
            if (maProdC.EtatCourant == Production.Statut.Demarree)
            {
                timerProdC.Start();
            }
        }
    }
}
