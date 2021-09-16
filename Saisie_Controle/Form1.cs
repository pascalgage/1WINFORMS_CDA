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
using ClassLibraryValidation;
using System.Data.SqlClient;
using ClassLibraryTransaction;

namespace Saisie_Controle
{
    public partial class Form1 : Form
    {
        //private const string ConnectionString = ("Data Source=(localdb)\\instancePascal;Initial " +
                                                 //"Catalog=ExerciceUSAbdd;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            
        }
        
       

        private bool ValidationNom()
        {
            if (Validation.IsValidName(textBoxName.Text))
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
            if (Validation.IsValidDate(textBoxDate.Text))
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


        private bool ValidationMontant()
        {
            if (Validation.IsValidMontant(textBoxMontant.Text))
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
            if (Validation.IsValidCodePostal(textBoxCodePostal.Text))
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

        //Méthode de Validation principale des champs...

        /*private void UserFeedBack()
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

            foreach (string item in errors)
            {
                listerrors += item + "\n";
            }

            if (!ok)
            {
                MessageBox.Show(listerrors, "VALIDATION IMPOSSIBLE !");
            }
            else
            {
                
                MessageBox.Show("Opération réussie", "INSERTION BDD");
            }



        }*/
        

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
            
            bool ok = true;

            MessageBox.Show("NOM:" + textBoxName.Text + "\nDATE:" + textBoxDate.Text + "\nMONTANT:" + textBoxMontant.Text +
                                "\nCODE POSTAL:" + textBoxCodePostal.Text, "Voulez-vous effectuer la VALIDATION des données ?", MessageBoxButtons.YesNo);

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

            foreach (string item in errors)
            {
                listerrors += item + "\n";
            }

            if (!ok)
            {
                MessageBox.Show(listerrors, "VALIDATION IMPOSSIBLE !");
            }
            else
            { 
                MessageBox.Show("Opération réussie", "INSERTION BDD");

                //Parsage des entrées textBox....

                string nom = textBoxName.Text;
                DateTime date;
                DateTime.TryParse(textBoxDate.Text,out date);
                Decimal montant = Decimal.Parse(textBoxMontant.Text);
                int codePostal = int.Parse(textBoxCodePostal.Text);
                
                //instanciation de l'objet matransaction....
                Transaction maTransaction = new Transaction(nom,date,montant,codePostal);


                //TransactionAffForm afficherTransaction = new TransactionAffForm(nom, date, montant, codePostal);
                TransactionAffForm afficherTransaction = new TransactionAffForm(maTransaction);
                afficherTransaction.ShowDialog();


            }
            
            

            //Commande SQL pour l'insertion dans InstancePascal...ExerciceUSAbdd...

            //SqlConnection con = new SqlConnection(ConnectionString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into clients values (@client_nom,@client_date,@client_montant,@client_codePostal)", con);
            //cmd.Parameters.AddWithValue("@client_nom",textBoxName.Text);
            //cmd.Parameters.AddWithValue("@client_date",textBoxDate.Text);
            //cmd.Parameters.AddWithValue("@client_montant",textBoxMontant.Text);
            //cmd.Parameters.AddWithValue("@client_codePostal",textBoxCodePostal.Text);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("INSERTION EN BDD clients réussie!");
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
             
                
                
            }
            

        }
    }
}
