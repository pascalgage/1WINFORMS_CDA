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
            labelRembousement.Text = monEmprunt.CalculDesMensualites().ToString();
            if (radioButt7perc.Checked)
            {
                monEmprunt.Taux = 0.07;
            }else if (radioButt8perc.Checked)
            {
                monEmprunt.Taux = 0.08;
            }else if (radioButt9perc.Checked)
            {
                monEmprunt.Taux = 0.09;
            }
        }
        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            monEmprunt.RemboursementDureeTotale = hScrollBarDuree.Value;
            UpdateEmprunt();
            //labelDure.Text = hScrollBarDuree.Value.ToString();

            //if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelDure.Text = hScrollBarDuree.Value.ToString();
            //    labelNBrVersement.Text = (dure / 1).ToString();
            //}
            //else if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelDure.Text = hScrollBarDuree.Value.ToString();
            //    labelNBrVersement.Text = (dure / 2).ToString();
            //}
            //else if (listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelDure.Text = hScrollBarDuree.Value.ToString();
            //    labelNBrVersement.Text = (dure / 3).ToString();
            //}
            //else if (listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelDure.Text = hScrollBarDuree.Value.ToString();
            //    labelNBrVersement.Text = (dure / 6).ToString();
            //}
            //else if (listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelDure.Text = hScrollBarDuree.Value.ToString();
            //    labelNBrVersement.Text = (dure / 12).ToString();
            //}

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButt8perc.Checked)
            {
                double k = double.Parse(textBoxCapitalEmpr.Text);
                double tx = 0.08;
                int per = 0;
                if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem) { per = 1; }
                if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem) { per = 2; }
                if (listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem) { per = 3; }
                if (listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem) { per = 6; }
                if (listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem) { per = 12; }

                int nmp = int.Parse(labelNBrVersement.Text);
                double resultat = Calcul.CalculdeMensualites(k, tx, nmp, per);
                labelRembousement.Text = resultat.ToString();
            }
            else if (radioButt7perc.Checked)
            {
                double k = double.Parse(textBoxCapitalEmpr.Text);
                double tx = 0.07;
                int per = 0;
                if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem) { per = 1; }
                if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem) { per = 2; }
                if (listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem) { per = 3; }
                if (listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem) { per = 6; }
                if (listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem) { per = 12; }

                int nmp = int.Parse(labelNBrVersement.Text);
                double resultat = Calcul.CalculdeMensualites(k, tx, nmp, per);
                labelRembousement.Text = resultat.ToString();

            }
            else if (radioButt9perc.Checked)
            {
                double k = double.Parse(textBoxCapitalEmpr.Text);
                double tx = 0.09;
                int per = 0;
                if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem) { per = 1; }
                if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem) { per = 2; }
                if (listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem) { per = 3; }
                if (listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem) { per = 6; }
                if (listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem) { per = 12; }

                int nmp = int.Parse(labelNBrVersement.Text);
                double resultat = Calcul.CalculdeMensualites(k, tx, nmp, per);
                labelRembousement.Text = resultat.ToString();
            }
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            monEmprunt.RemboursementFrequence = (Emprunt.Frequence)listBoxPeriodicite.SelectedItem;
            UpdateEmprunt();
            //if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelNBrVersement.Text = (dure / 1).ToString();
            //}
            //else if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelNBrVersement.Text = (dure / 2).ToString();

            //    hScrollBarDuree.SmallChange = 2;
            //    hScrollBarDuree.LargeChange = 2;
            //    hScrollBarDuree.Minimum = 2;
            //    hScrollBarDuree.Value = 2;

            //}
            //else if (listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelNBrVersement.Text = (dure / 3).ToString();

            //    hScrollBarDuree.SmallChange = 3;
            //    hScrollBarDuree.LargeChange = 3;
            //    hScrollBarDuree.Minimum = 3;
            //    hScrollBarDuree.Value = 3;
            //}
            //else if (listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelNBrVersement.Text = (dure / 6).ToString();

            //    hScrollBarDuree.SmallChange = 6;
            //    hScrollBarDuree.LargeChange = 6;
            //    hScrollBarDuree.Minimum = 6;
            //    hScrollBarDuree.Value = 6;
            //}
            //else if (listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem)
            //{
            //    int dure = int.Parse(hScrollBarDuree.Value.ToString());
            //    labelNBrVersement.Text = (dure / 12).ToString();

            //    hScrollBarDuree.SmallChange = 12;
            //    hScrollBarDuree.LargeChange = 12;
            //    hScrollBarDuree.Minimum = 12;
            //    hScrollBarDuree.Value = 12;
            //}

            //labelDure.Text = hScrollBarDuree.Value.ToString();
        }
    }
}
