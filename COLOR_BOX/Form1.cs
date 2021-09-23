using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLOR_BOX
{
    public partial class Form1 : Form
    {

        private System.Drawing.Color maCouleur;


        public Form1()
        {
            InitializeComponent();

            maCouleur = Color.FromArgb(55, 25, 75);
            MettreAJourLIHM();
        }


        private void MettreAJourLIHM()
        {
            labelRedSample.BackColor = Color.FromArgb(maCouleur.R,0,0);
            labelGreenSample.BackColor = Color.FromArgb(0,maCouleur.G,0);
            labelBlueSample.BackColor = Color.FromArgb(0,0,maCouleur.B);

            hScrollBarRed.Value = maCouleur.R;
            hScrollBarGreen.Value = maCouleur.G;
            hScrollBarBlue.Value = maCouleur.B;

            numericUpDownRed.Value = maCouleur.R;
            numericUpDownGreen.Value = maCouleur.G;
            numericUpDownBlue.Value = maCouleur.B;

            labelRGBsample.BackColor = maCouleur;

        }

        //SCROLL DANS LES BARRE DE MESURE de DROITE à GAUCHE

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        {
            //quand je scroll la hscrollbar value et la numeric upandDown sont synchrones
            numericUpDownRed.Value = hScrollBarRed.Value;
            //la hscrollbar value et la couleur de fond du label soit synchro
            labelRedSample.BackColor = Color.FromArgb(hScrollBarRed.Value, 0, 0);
            //le rgbsample rendu doit être modifié...
            labelRGBsample.BackColor = Color.FromArgb(hScrollBarRed.Value, 0, 0);

   

        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownGreen.Value = hScrollBarGreen.Value;
            labelGreenSample.BackColor = Color.FromArgb(0,hScrollBarGreen.Value, 0);
            labelRGBsample.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, 0);
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDownBlue.Value = hScrollBarBlue.Value;
            labelBlueSample.BackColor = Color.FromArgb(0, 0, hScrollBarBlue.Value);
            labelRGBsample.BackColor = Color.FromArgb(hScrollBarRed.Value, hScrollBarGreen.Value, hScrollBarBlue.Value);
        }


        //CHANGEMENT DE VALEURS DANS LES BOX 255

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb((int)numericUpDownRed.Value, maCouleur.G, maCouleur.B);
            this.MettreAJourLIHM();
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, (int)numericUpDownGreen.Value, maCouleur.B);
            this.MettreAJourLIHM();
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, (int)numericUpDownBlue.Value);
            this.MettreAJourLIHM();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb((int)numericUpDownRed.Value, (int)numericUpDownGreen.Value, (int)numericUpDownBlue.Value);

            string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            hexa.Text = "#"+hex;
        }
    }
}
