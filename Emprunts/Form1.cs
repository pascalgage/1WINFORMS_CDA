using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBarDuree_Scroll(object sender, ScrollEventArgs e)
        {
            labelDure.Text = hScrollBarDuree.Value.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (radioButt8perc.Checked)
            {
                double k = double.Parse(textBoxCapitalEmpr.Text);
                double tx = 8;
                double m = double.Parse(labelDure.Text);
                double result = 0;

                result = ((k * tx/100)/m);
                labelRembousement.Text = result.ToString();


            }else if (radioButt7perc.Checked)
            {

            }else if (radioButt9perc.Checked)
            {

            }
            
        }
    }
}
