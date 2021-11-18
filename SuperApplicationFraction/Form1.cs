using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperApplicationFraction
{
    public partial class Form1 : Form
    {
        private Fraction mafraction;
        private Fraction mafraction2;

        public Form1()
        {
            InitializeComponent();
            mafraction = new Fraction();
            mafraction2 = new Fraction();

        }
        
        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            
            mafraction.Numerateur = int.Parse(textBoxNum1.Text);
            mafraction.Denominateur = int.Parse(textBoxDen1.Text);


            if (radioButtonAdd.Checked == true)
            {
                mafraction2.Numerateur = int.Parse(textBoxNum2.Text);
                mafraction2.Denominateur = int.Parse(textBoxDen2.Text);
                textBoxNum2.Enabled = true;
                textBoxDen2.Enabled = true;
                labelResult.Text = mafraction.Plus(mafraction2).ToString();   
            }
            if (radioButtonSoust.Checked == true)
            {
                mafraction2.Numerateur = int.Parse(textBoxNum2.Text);
                mafraction2.Denominateur = int.Parse(textBoxDen2.Text);
                textBoxNum2.Enabled = true;
                textBoxDen2.Enabled = true;
                labelResult.Text = mafraction.Moins(mafraction2).ToString();
            }
            if (radioButtonMult.Checked == true)
            {
                mafraction2.Numerateur = int.Parse(textBoxNum2.Text);
                mafraction2.Denominateur = int.Parse(textBoxDen2.Text);
                textBoxNum2.Enabled = true;
                textBoxDen2.Enabled = true;
                labelResult.Text = mafraction.Multiplie(mafraction2).ToString();
            }
            if (radioButtonDiv.Checked == true)
            {
                mafraction2.Numerateur = int.Parse(textBoxNum2.Text);
                mafraction2.Denominateur = int.Parse(textBoxDen2.Text);
                textBoxNum2.Enabled = true;
                textBoxDen2.Enabled = true;
                labelResult.Text = mafraction.Divise(mafraction2).ToString();
            }
            if (radioButtonRed.Checked == true)
            {
                textBoxNum2.Enabled = false;
                textBoxDen2.Enabled = false;
                labelResult.Text = mafraction.Reduction(mafraction).ToString();
            }
        }

        private void textBoxDen1_Leave(object sender, EventArgs e)
        {
            if (textBoxDen1.Text == 0.ToString())
            {
                errorProviderDen1.SetError(textBoxDen1, "Erreur: Tentative de division par zéro !");
                textBoxDen1.BackColor = Color.Red;
            }
            else
            {
                errorProviderDen1.Clear();
                textBoxDen1.BackColor = Color.White;
            }
        }

        private void textBoxDen2_Leave(object sender, EventArgs e)
        {
            if (textBoxDen2.Text == 0.ToString())
            {
                errorProviderDen2.SetError(textBoxDen2, "Erreur: Tentative de division par zéro !");
                textBoxDen2.BackColor = Color.Red;
            }
            else
            {
                errorProviderDen2.Clear();
                textBoxDen2.BackColor = Color.White;
            }
        }

        private void radioButtonRed_Click(object sender, EventArgs e)
        {
            textBoxNum2.Enabled = false;
            textBoxDen2.Enabled = false;
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNum2.Enabled = true;
            textBoxDen2.Enabled = true;
        }

        private void radioButtonSoust_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNum2.Enabled = true;
            textBoxDen2.Enabled = true;
        }

        private void radioButtonMult_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNum2.Enabled = true;
            textBoxDen2.Enabled = true;
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNum2.Enabled = true;
            textBoxDen2.Enabled = true;
        }

        private void textBoxNum1_Leave(object sender, EventArgs e)
        {
            uint nombre = uint.Parse(textBoxNum1.Text);

            if (Fraction.EstUnNombrepremier(nombre))
            {
                MessageBox.Show("LE NOMBRE "+textBoxNum1.Text+" EST PREMIER !");
            }
        }
    }
}
