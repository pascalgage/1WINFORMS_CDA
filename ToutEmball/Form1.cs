﻿using ClassLibraryProduction;
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

        private void timerProdA_Tick(object sender, EventArgs e)
        {
            maProdA.ProduireUneCaisse();
            //afficher dans la case de nbre de caisses depuis demarrage le nombre de caisse depart
            textCaissDepDemA.Text = maProdA.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarA.Value = (int)maProdA.QuantiteDeCaisseDepuisdemarrage;
        }

        private void aToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            //Demarrer le timerProdA....
            timerProdA.Start();
            
        }

        private void timerProdB_Tick(object sender, EventArgs e)
        {
            maProdB.ProduireUneCaisse();
            textCaissDepDemB.Text = maProdB.QuantiteDeCaisseDepuisdemarrage.ToString();
            progressBarB.Value = (int)maProdB.QuantiteDeCaisseDepuisdemarrage;
        }


        private void bToolStripMenuIDem_Click(object sender, EventArgs e)
        {
            timerProdB.Start();
        }

        
    }
}
