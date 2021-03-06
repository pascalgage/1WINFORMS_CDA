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

namespace ToutEmballV1
{
    public partial class FormProd: Form
    {
        private Production maProdA;
        private Production maProdB;
        private Production maProdC;

        public delegate void DelegateMettreAJour();

        public FormProd()
        {
            InitializeComponent();
            maProdA = new Production("A",10000,1000);
            maProdB = new Production("B", 25000, 5000);
            maProdC = new Production("C", 120000, 10000);
            maProdA.CaisseProduite += MaProdA_CaisseProduite;
            maProdB.CaisseProduite += MaProdB_CaisseProduite;
            maProdC.CaisseProduite += MaProdC_CaisseProduite;
            uCprogressBarProduction1.LabelProductionAText = "Production A";
            uCprogressBarProduction2.LabelProductionAText = "Production B";
            uCprogressBarProduction3.LabelProductionAText = "Production C";
            MettreAJourIHM();
            
        }

        private void MaProdC_CaisseProduite(Production sender)
        {
            this.Invoke(new DelegateMettreAJour(MettreAJourIHM));
        }

        private void MaProdB_CaisseProduite(Production sender)
        {
            this.Invoke(new DelegateMettreAJour(MettreAJourIHM));
        }

        private void MaProdA_CaisseProduite(Production sender)
        {
           this.Invoke(new DelegateMettreAJour(MettreAJourIHM));
        }

        //Commencer la production....


        private void aToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            maProdA.Demarrer();
            MettreAJourIHM();  
        }

        private void bToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            maProdB.Demarrer();
            MettreAJourIHM(); 
        }

        private void cToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            maProdC.Demarrer();
            MettreAJourIHM();  
        }

        //Suspendre Production...

        private void aToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdA.MettreEnPause();
            
            MettreAJourIHM();      
        }

        private void bToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdB.MettreEnPause();
            MettreAJourIHM();  
        }

        private void cToolStripMenuIArr_Click(object sender, EventArgs e)
        {
            maProdC.MettreEnPause();
            MettreAJourIHM();
        }
        //Reprendre la production....

        private void aToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdA.ReprendreLaProduction();
            
                MettreAJourIHM();
        }

        private void bToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdB.ReprendreLaProduction();
            
                MettreAJourIHM();
           
        }

        private void cToolStripMenuICont_Click(object sender, EventArgs e)
        {
            maProdC.ReprendreLaProduction();
            
                MettreAJourIHM();
            
        }

        private void quitterToolStripMenuItem_Click(object sender,EventArgs e)
        {
            

            this.Close();
            
            

        }
        


        //Mise à jour de l'IHM...

        private void MettreAJourIHM()
        {
            
            uCprogressBarProduction1.ProgressBarProdValue = maProdA.QuantiteDeCaisseDepuisdemarrage;
            uCprogressBarProduction1.ProgressBarProdMaximum = maProdA.QuantiteAProduire;
            uCpanelTypeProd1.NombreDeCaisseProduite = maProdA.QuantiteDeCaisseDepuisdemarrage.ToString();
            uCpanelTypeProd1.NombreDefaut = maProdA.TauxErreur().ToString();

            uCprogressBarProduction2.ProgressBarProdValue = maProdB.QuantiteDeCaisseDepuisdemarrage;
            uCprogressBarProduction2.ProgressBarProdMaximum = maProdB.QuantiteAProduire;
            uCpanelTypeProd2.NombreDeCaisseProduite = maProdB.QuantiteDeCaisseDepuisdemarrage.ToString();
            uCpanelTypeProd2.NombreDefaut = maProdB.TauxErreur().ToString();

            uCprogressBarProduction3.ProgressBarProdValue = maProdC.QuantiteDeCaisseDepuisdemarrage;
            uCprogressBarProduction3.ProgressBarProdMaximum = maProdC.QuantiteAProduire;
            uCpanelTypeProd3.NombreDeCaisseProduite = maProdC.QuantiteDeCaisseDepuisdemarrage.ToString();
            uCpanelTypeProd3.NombreDefaut = maProdC.TauxErreur().ToString();


            if (maProdA.EtatCourant == Production.StatutProd.Demarree)
            {
                aToolStripMenuIDem.Enabled = false;
                aToolStripMenuIArr.Enabled = true;
                aToolStripMenuICont.Enabled = false;
                

            }
            if(maProdB.EtatCourant == Production.StatutProd.Demarree)
            {
                bToolStripMenuIDem.Enabled = false;
                bToolStripMenuIArr.Enabled = true;
                bToolStripMenuICont.Enabled = false;

            }
            if (maProdC.EtatCourant == Production.StatutProd.Demarree)
            {
                cToolStripMenuIDem.Enabled = false;
                cToolStripMenuIArr.Enabled = true;
                cToolStripMenuICont.Enabled = false;

            }


            if (maProdA.EtatCourant == Production.StatutProd.Suspendue)
            {
                aToolStripMenuIDem.Enabled = true;
                aToolStripMenuIArr.Enabled = false;
                aToolStripMenuICont.Enabled = true;


            }
            if (maProdB.EtatCourant == Production.StatutProd.Suspendue)
            {
                bToolStripMenuIDem.Enabled = true;
                bToolStripMenuIArr.Enabled = false;
                bToolStripMenuICont.Enabled = true;

            }
            if (maProdC.EtatCourant == Production.StatutProd.Suspendue)
            {
                cToolStripMenuIDem.Enabled = true;
                cToolStripMenuIArr.Enabled = false;
                cToolStripMenuICont.Enabled = true;

            }


            if (maProdA.EtatCourant == Production.StatutProd.NonDemarree)
            {

                aToolStripMenuIArr.Enabled = false;
                aToolStripMenuICont.Enabled = false;
            }
            if (maProdB.EtatCourant == Production.StatutProd.NonDemarree)
            {

                bToolStripMenuIArr.Enabled = false;
                bToolStripMenuICont.Enabled = false;
            }
            if (maProdC.EtatCourant == Production.StatutProd.NonDemarree)
            {

                cToolStripMenuIArr.Enabled = false;
                cToolStripMenuICont.Enabled = false;
            }

            

        }

       

    }
}
