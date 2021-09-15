using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Saisie_Controle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool ValidationNom()
        {
            if ((Regex.Match(textBoxName.Text, "^[a-zA-Z]*$").Success) && (textBoxName.Text.Length <= 30) && (textBoxName.Text != ""))
            {
                MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                "\nCODE POSTAL:" + textBoxCodePostal.Text);
                errorProviderNom.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR le nom ne doit comporter que des lettres");
                errorProviderNom.SetError(textBoxName, "ERROR le nom ne doit comporter que des lettres");
                return false;
            }
                
        }

        private bool ValidationDate()
        {
            if ((DateTime.TryParse(textBoxDate.Text, out DateTime result)))
            {
                MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                 "\nCODE POSTAL:" + textBoxCodePostal.Text);
                errorProviderDate.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR la date doit être de forme JJMMAAAA");
                errorProviderDate.SetError(textBoxDate, "ERROR la date doit être de forme JJMMAAAA");
                return false;
            }

            
        }


        private bool ValidationMontant()
        {
            if (Regex.Match(textBoxMontant.Text, "^[0-9]+([.,]{1}[0-9]{2})?$").Success)
            {
                MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                "\nCODE POSTAL:" + textBoxCodePostal.Text);
                errorProviderMontant.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR le montant doit être numérique");
                errorProviderMontant.SetError(textBoxMontant, "ERROR le montant doit être numérique");
                return false;
            }

        }

       

        private bool ValidationCodePostal()
        {
            if ((textBoxCodePostal.Text.Length < 6) && (Regex.Match(textBoxCodePostal.Text, "^[0-9]*$").Success))
            {
                MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                 "\nCODE POSTAL:" + textBoxCodePostal.Text);
                errorProviderCP.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("ERROR le code postal = maximun 5 chiffres");
                errorProviderCP.SetError(textBoxCodePostal, "ERROR le code postal = maximun 5 chiffres");
                return false;
            }
                
        }

        private bool EffacementDesChamps()
        {
            textBoxName.Text = "";
            textBoxDate.Text = "";
            textBoxMontant.Text = "";
            textBoxCodePostal.Text = "";

            return true;
        }



        private void Validation()
        {
            bool ok =true;
            ok= ok &&ValidationNom();
            ok = ok && ValidationDate();
            ok = ok && ValidationMontant();
            ok = ok && ValidationCodePostal();

        }

       //Lancement de la Validation du champ quand on quitte chaque champ
        
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            ValidationNom();
        }
        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            ValidationDate();
        }
        private void textBoxMontant_Leave(object sender, EventArgs e)
        {
            ValidationMontant();
        }
        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            ValidationCodePostal();
        }

        //Boutons VALIDER puis EFFACER

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Validation();

        }
        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            EffacementDesChamps();
        }

        
    }
}
