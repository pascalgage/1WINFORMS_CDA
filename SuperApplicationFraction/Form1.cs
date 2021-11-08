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


            mafraction2.Numerateur = int.Parse(textBoxNum2.Text);
            mafraction2.Denominateur = int.Parse(textBoxDen2.Text);


            if (radioButtonAdd.Checked == true)
            {
                labelResult.Text = mafraction.Plus(mafraction2).ToString();   
            }
            if (radioButtonSoust.Checked == true)
            {
                labelResult.Text = mafraction.Moins(mafraction2).ToString();
            }
            if (radioButtonMult.Checked == true)
            {
                labelResult.Text = mafraction.Multiplie(mafraction2).ToString();
            }
            if (radioButtonDiv.Checked == true)
            {
                labelResult.Text = mafraction.Divise(mafraction2).ToString();
            }
        }
    }
}
