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
        
        private const double Taux7 = 0.07;
        private const double Taux8 = 0.08;
        private const double Taux9 = 0.09;

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
                monEmprunt.Taux = Taux7;
            }
            else if (radioButt8perc.Checked)
            {
                monEmprunt.Taux = Taux8;
            }
            else if (radioButt9perc.Checked)
            {
                monEmprunt.Taux = Taux9;
            }
            if (monEmprunt.Taux == Taux7)
            {
                radioButt7perc.Checked = true;
            }else if(monEmprunt.Taux == Taux8)
            {
                radioButt8perc.Checked = true;
            }else if(monEmprunt.Taux == Taux9)
            {
                radioButt9perc.Checked = true;
            }
            
        }

        private void textBoxCapitalEmpr_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCapitalEmpr.Text, out int k))
            {
                monEmprunt.Capital = k;
                UpdateEmprunt();
            }
            else
            {
                MessageBox.Show("Le capital saisi doit être un entier positif !");
            }
               
            
            

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

        private void textBoxCapitalEmpr_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCapitalEmpr.Text,out int kemprunte))
            {
                monEmprunt.Capital = kemprunte;
                UpdateEmprunt();
            }

            
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            monEmprunt.Nom = textBoxNom.Text;
            UpdateEmprunt();
        }
    }
}
