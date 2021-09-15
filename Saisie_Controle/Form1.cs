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

        private void Validation()
        {
            
            if ((Regex.Match(textBox1.Text, "^[a-zA-Z]*$").Success) && (textBox1.Text.Length <= 30) && (textBox1.Text != ""))
            {
                if ((Regex.Match(textBox2.Text, "^[0-9]*$").Success) && (textBox2.Text.Length == 8))
                {
                    if (Regex.Match(textBox3.Text, "^[0-9]*$").Success)
                    {
                        if ((textBox4.Text.Length < 6) && (Regex.Match(textBox4.Text, "^[0-9]*$").Success))
                        {
                            errorProviderNom.Clear();
                            errorProviderDate.Clear();
                            errorProviderMontant.Clear();
                            errorProviderCP.Clear();
                            MessageBox.Show("NOM:" + textBox1.Text + "\nDATE:" + textBox2.Text + "\nMONTANT:" + textBox3.Text +
                                 "\nCODE POSTAL:" + textBox4.Text);
                        }
                        else
                        {
                            MessageBox.Show("ERROR le code postal = maximun 5 chiffres");
                            errorProviderCP.SetError(textBox4, "ERROR le code postal = maximun 5 chiffres");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ERROR le montant doit être numérique");
                        errorProviderMontant.SetError(textBox3, "ERROR le montant doit être numérique");
                    }

                }
                else
                {
                    MessageBox.Show("ERROR la date doit être de forme JJMMAAAA");
                    errorProviderDate.SetError(textBox2, "ERROR la date doit être de forme JJMMAAAA");
                }

            }
            else
            {
                MessageBox.Show("ERROR le nom ne doit comporter que des lettres");
                errorProviderNom.SetError(textBox1, "ERROR le nom ne doit comporter que des lettres");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation();

        }
        //bool successful = DateTime.TryParseExact
        //("20201205", "yyyyMMdd", null, System.Globalization.DateTimeStyles.AllowLeadingWhite, out dateARecupere);
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //Validation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
