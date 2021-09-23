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
            if (listBoxPeriodicite.Items[0] == listBoxPeriodicite.SelectedItem)
            {
                int dure = int.Parse(hScrollBarDuree.Value.ToString());
                labelDure.Text = hScrollBarDuree.Value.ToString();
                labelNBrVersement.Text = (dure * 1).ToString();
            }else if (listBoxPeriodicite.Items[1] == listBoxPeriodicite.SelectedItem)
            {
                int dure = int.Parse(hScrollBarDuree.Value.ToString());
                labelDure.Text = hScrollBarDuree.Value.ToString();
                labelNBrVersement.Text = (dure / 2).ToString();
            }else if(listBoxPeriodicite.Items[2] == listBoxPeriodicite.SelectedItem)
            {
                int dure = int.Parse(hScrollBarDuree.Value.ToString());
                labelDure.Text = hScrollBarDuree.Value.ToString();
                labelNBrVersement.Text = (dure / 4).ToString();
            }else if(listBoxPeriodicite.Items[3] == listBoxPeriodicite.SelectedItem)
            {
                int dure = int.Parse(hScrollBarDuree.Value.ToString());
                labelDure.Text = hScrollBarDuree.Value.ToString();
                labelNBrVersement.Text = (dure / 6).ToString();
            }else if(listBoxPeriodicite.Items[4] == listBoxPeriodicite.SelectedItem)
            {
                int dure = int.Parse(hScrollBarDuree.Value.ToString());
                labelDure.Text = hScrollBarDuree.Value.ToString();
                labelNBrVersement.Text = (dure / 12).ToString();
            }
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            
        }

        
    }
}
