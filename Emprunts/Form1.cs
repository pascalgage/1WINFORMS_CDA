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
    public partial class FormEmp : Form
    {


        private const double Taux7 = 0.07;
        private const double Taux8 = 0.08;
        private const double Taux9 = 0.09;

        private Emprunt monEmprunt;

        public FormEmp()
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
            monEmprunt.lamensualiteestOver += MonEmprunt_lamensualiteestOver;
            monEmprunt.lamensualiteOK += MonEmprunt_lamensualiteOK;
            UpdateEmprunt();
            
        }

        private void MonEmprunt_lamensualiteOK(Emprunt sender)
        {
            labelRemboursement.BackColor = Color.Green;
        }

        private void MonEmprunt_lamensualiteestOver(Emprunt sender)
        {
            labelRemboursement.BackColor = Color.Red;

        }

        private void UpdateEmprunt()
        {
            
            textBoxNom.Text = monEmprunt.Nom;
            textBoxCapitalEmpr.Text = monEmprunt.Capital.ToString();
            labelDure.Text = monEmprunt.RemboursementDureeTotale.ToString();
            listBoxPeriodicite.SelectedItem = monEmprunt.RemboursementFrequence;
            labelNBrVersement.Text = monEmprunt.CalculNombreRemboursement().ToString();
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
            labelRemboursement.Text = monEmprunt.CalculDesMensualites().ToString();

        }

        private void textBoxCapitalEmpr_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCapitalEmpr.Text, out double k) && Emprunt.IsvalidK(textBoxCapitalEmpr.Text))
            {
                monEmprunt.Capital = k;
                UpdateEmprunt();
            }
            else
            {
                errorProK.SetError(textBoxCapitalEmpr,"ERREUR!!!");
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
            
                UpdateEmprunt();

        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            monEmprunt.RemboursementFrequence = (Emprunt.Frequence)listBoxPeriodicite.SelectedItem;
            UpdateEmprunt();

            if (listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[0])
            {
                hScrollBarDuree.Height = 23;
               

            }else if(listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[1])
            {
                hScrollBarDuree.SmallChange = 2;
                hScrollBarDuree.LargeChange = 2;
                hScrollBarDuree.Minimum = 2;
                hScrollBarDuree.Value = 2;
                hScrollBarDuree.Height = 30;
               
            }
            else if(listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[2])
            {
                hScrollBarDuree.SmallChange = 3;
                hScrollBarDuree.LargeChange = 3;
                hScrollBarDuree.Minimum = 3;
                hScrollBarDuree.Value = 3;
                hScrollBarDuree.Height = 37;
                
            }
            else if(listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[3])
            {
                hScrollBarDuree.SmallChange = 6;
                hScrollBarDuree.LargeChange = 6;
                hScrollBarDuree.Minimum = 6;
                hScrollBarDuree.Value = 6;
                hScrollBarDuree.Height = 44;
                
            }
            else if(listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[4])
            {
                hScrollBarDuree.SmallChange = 12;
                hScrollBarDuree.LargeChange = 12;
                hScrollBarDuree.Minimum = 12;
                hScrollBarDuree.Value = 12;
                hScrollBarDuree.Height = 53;
                
            }

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

        private void Reinitialise()
        {
            monEmprunt = new Emprunt();
            UpdateEmprunt();
            

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Reinitialise();
        }

        
    }
}
