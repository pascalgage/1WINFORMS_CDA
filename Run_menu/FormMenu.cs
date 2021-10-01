using Additionneur;
using CheckBox;
using COLOR_BOX;
using Emprunts;
using Saisie_Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //Compteur pour ouverture de fenêtres...N°1,2 etc...
        int compteur = 1;
        private object menuStripConnection;

        public int Compteur { get => compteur; set => compteur = value; }
        //Fin compteur

        private void sousMenuIdentify_Click(object sender, EventArgs e)
        {
            Identity identify = new Identity();
            DialogResult reponse= identify.ShowDialog();
            if (reponse == DialogResult.OK)
            {
                // activer mes menus
                this.phase1ToolStrip.Enabled = true;
                this.phase2ToolStrip.Enabled = true;
                this.phase3ToolStrip.Enabled = true;
                this.fenetresToolStrip.Enabled = true;
            }

        }

        private void toolStripQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd appli1 = new FormAdd();
            appli1.Text += " N°" + Compteur++;
            appli1.MdiParent = this;
            appli1.Show();

        }

        private void checBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormCheck appli2 = new FormCheck();
            //appli2.Text += " N°" + Compteur++;
            //appli2.MdiParent = this;
            //appli2.Show();

            boxSaisie appliIntermediaire = new boxSaisie();
            appliIntermediaire.TextSaisietValide += AppliIntermediaire_TextSaisietValide;
            appliIntermediaire.MdiParent = this;
            appliIntermediaire.Show();

        }

        

        private void AppliIntermediaire_TextSaisietValide(string montexte)
        {
            

            FormCheck appli2 = new FormCheck(montexte);

            appli2.Text += " N°" + Compteur++;

            appli2.MdiParent = this;

            appli2.Show();
            
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSais appli3 = new FormSais();
            appli3.Text += " N°" + Compteur++;
            appli3.MdiParent = this;
            appli3.Show();
        }

        private void colorBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCol appli4 = new FormCol();
            appli4.Text += " N°" + Compteur++;
            appli4.MdiParent = this;
            appli4.Show();
        }

        private void empruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmp appli5 = new FormEmp();
            appli5.Text += " N°" + Compteur++;
            appli5.MdiParent = this;
            appli5.Show();
        }

        private void fenetresToolStrip_Click(object sender, EventArgs e)
        {
            
            //this.menuStripConnection.MdiWindowListItem = this.fenetresToolStripMenuItem;
            
        }
    }
}
