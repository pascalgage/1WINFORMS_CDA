using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryCalculFinancier;
namespace Emprunts
{
    public partial class Form1 : Form
    {
        private Emprunt monEmprunt;

        public Form1()
        {
            InitializeComponent();
            listBoxPeriodicite.Items.AddRange(new object[]
            {
                Emprunt.Frequence.Mensuelle,
                Emprunt.Frequence.Bimestrielle,
                Emprunt.Frequence.Trimestrielle,
                Emprunt.Frequence.Semestrielle,
                Emprunt.Frequence.Annuelle
            });

            monEmprunt = new Emprunt();
            UpdateEmprunt();
        }
        private void UpdateEmprunt()
        {
            textBoxNom.Text = monEmprunt.Nom;
            textBoxCapitalEmpr.Text = monEmprunt.Capital.ToString();
            labelDure.Text = monEmprunt.RemboursementDureeTotale.ToString();
            listBoxPeriodicite.SelectedItem = monEmprunt.RemboursementFrequence;
            labelNBrVersement.Text = monEmprunt.CalculNombreRemboursement().ToString();
            labelRemboursement.Text = monEmprunt.CalculDesMensualites().ToString();
            if (radioButt7perc.Checked)
            {
                monEmprunt.Taux = 0.07;
            }
            else if (radioButt8perc.Checked)
            {
                monEmprunt.Taux = 0.08;
            }
            else if (radioButt9perc.Checked)
            {
                monEmprunt.Taux = 0.09;
            }
        }

        private void textBoxCapitalEmpr_Leave(object sender, EventArgs e)
        {

            monEmprunt.Capital = int.Parse(textBoxCapitalEmpr.Text);
            UpdateEmprunt();

        }



        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            monEmprunt.RemboursementDureeTotale = hScrollBarDuree.Value;
            UpdateEmprunt();
           
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButt8perc.Checked)
            {
                double resultat=monEmprunt.CalculDesMensualites();
                
                labelRemboursement.Text = resultat.ToString();
                UpdateEmprunt();
            }
            else if (radioButt7perc.Checked)
            {
                double resultat = monEmprunt.CalculDesMensualites();
                
                labelRemboursement.Text = resultat.ToString();
                UpdateEmprunt();

            }
            else if (radioButt9perc.Checked)
            {

                double resultat = monEmprunt.CalculDesMensualites();
                
                labelRemboursement.Text = resultat.ToString();
                UpdateEmprunt();
            }
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            monEmprunt.RemboursementFrequence = (Emprunt.Frequence)listBoxPeriodicite.SelectedItem;
            UpdateEmprunt();
            
        }

        

        
    }
}
