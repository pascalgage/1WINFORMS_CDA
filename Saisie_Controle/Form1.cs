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
                
                errorProviderNom.Clear();
                return true;
            }
            else
            {
                
                errorProviderNom.SetError(textBoxName, "Erreur: le nom ne doit comporter que des lettres");
                textBoxName.BackColor = Color.Red;
                return false;
            }
                
        }

        private bool EffacementColorNom()
        {
            if (ValidationNom())
            {
                textBoxName.BackColor = Color.White;
            }
            return true;
        }

        private bool ValidationDate()
        {
            if (IsDateValidAfterToday(textBoxDate.Text))
            {
                
                errorProviderDate.Clear();
                return true;
            }
            else
            {
                
                errorProviderDate.SetError(textBoxDate, "Erreur: la date doit être de forme JJ/MM/AAAA et postérieure à date actuelle !");
                textBoxDate.BackColor = Color.Red;
                return false;
            }

            
        }

        private bool EffacementColorDate()
        {
            if (ValidationDate())
            {
                textBoxDate.BackColor = Color.White;
            }
            return true;
        }

        //Vérification de date postérieure à date Actuelle /Utilisateur

        private bool IsDateValidAfterToday(string strDate)
        {
            DateTime resultDate;
            DateTime.TryParse(strDate, out resultDate);
            DateTime dateDuJour = DateTime.Now;
            return resultDate > dateDuJour;
        }


        private bool ValidationMontant()
        {
            if (Regex.Match(textBoxMontant.Text, "^[0-9]+([.,]{1}[0-9]{2})?$").Success)
            {
                
                errorProviderMontant.Clear();
                return true;
            }
            else
            {
                
                errorProviderMontant.SetError(textBoxMontant, "Erreur: le montant doit être entier ou decimal à deux chiffres après la virgule");
                textBoxMontant.BackColor = Color.Red;
                return false;
            }

        }

        private bool EffacementColorMontant()
        {
            if (ValidationMontant())
            {
                textBoxMontant.BackColor = Color.White;
            }
            return true;
        }



        private bool ValidationCodePostal()
        {
            if ((textBoxCodePostal.Text.Length < 6) && (textBoxCodePostal.Text !="")&&(Regex.Match(textBoxCodePostal.Text, "^[0-9]*$").Success))
            {
               
                errorProviderCP.Clear();
                return true;
            }
            else
            {
                
                errorProviderCP.SetError(textBoxCodePostal, "Erreur: le code postal = maximum 5 chiffres");
                textBoxCodePostal.BackColor = Color.Red;
                return false;
            }
                
        }

        private bool EffacementColorCP()
        {
            if (ValidationCodePostal())
            {
                textBoxCodePostal.BackColor = Color.White;
            }
            return true;
        }

        private bool EffacementDesChamps()
        {
            textBoxName.Text = "";
            textBoxDate.Text = "";
            textBoxMontant.Text = "";
            textBoxCodePostal.Text = "";

            errorProviderNom.Clear();
            errorProviderDate.Clear();
            errorProviderMontant.Clear();
            errorProviderCP.Clear();

            textBoxName.BackColor = Color.White;
            textBoxDate.BackColor = Color.White;
            textBoxMontant.BackColor = Color.White;
            textBoxCodePostal.BackColor = Color.White;

            return true;
        }

        
        private void Validation()
        {
            bool ok = true;
            
            MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                "\nCODE POSTAL:" + textBoxCodePostal.Text, "Voulez-vous effectuer la VALIDATION des données ?",MessageBoxButtons.YesNo);


            List<string> errors = new List<string>();

            
            if (!ValidationNom())
            {
                errors.Add("Nom incorrect");
                ok = false;
                
            }

            if (!ValidationDate())
            {
                errors.Add("Date incorrecte");
                ok = false;

            }

            if (!ValidationMontant())
            {
                errors.Add("Montant incorrect");
                ok = false;

            }

            if (!ValidationCodePostal())
            {
                errors.Add("Code postal incorrect");
                ok = false;

            }

            string listerrors = "";
            foreach (var item in errors)
            {
                listerrors += item + "\n";
            }
            if (!ok)
            {
                MessageBox.Show(listerrors, "VALIDATION IMPOSSIBLE !");
            }



        }
        

       //Lancement de la Validation du champ quand on quitte chaque champ
        
        private void textBoxName_Leave(object sender, EventArgs e)
        {
            ValidationNom();
            EffacementColorNom();
            
        }
        private void textBoxDate_Leave(object sender, EventArgs e)
        {
            ValidationDate();
            EffacementColorDate();
            
        }
        private void textBoxMontant_Leave(object sender, EventArgs e)
        {
            ValidationMontant();
            EffacementColorMontant();
        }
        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            ValidationCodePostal();
            EffacementColorCP();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application ?", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                EffacementDesChamps();
                
                
            }
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                EffacementDesChamps();
            }

        }
    }
}
