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
            double k = double.Parse(textBoxCapitalEmpr.Text);
            double tx = 0.08;
            int nm = 12;

            double res=Calcul.CalculdeMensualites(k, tx, nm);
            labelRembousement.Text = res.ToString();
            //if (listBoxPeriodicite.SelectedItem == listBoxPeriodicite.Items[3]&& radioButt8perc.Checked)
            //{
            //    double mensualitesPrevues = double.Parse(labelDure.Text);
            //    labelNBrVersement.Text = (mensualitesPrevues / 2).ToString();


            //    double k = double.Parse(textBoxCapitalEmpr.Text);// k Capital
            //    double tx = 8;// tx TAUX ANNUEL





            //    double m = double.Parse(labelDure.Text);
            //    double result = 0;

            //    result = ((k * tx / 100) * m);
            //    labelRembousement.Text = result.ToString();
            //}




            if (radioButt8perc.Checked)
            {
                


            }else if (radioButt7perc.Checked)
            {

            }else if (radioButt9perc.Checked)
            {

            }

            
            
        }
    }
}
