using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxSOURCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBoxSOURCE.Items.Add(comboBoxSOURCE.Text);
                //pour enlever le son...
                e.Handled = true;
                //pour vider le champ...
                comboBoxSOURCE.Text = "";
                
            }
            
        }
        //INSERT....
        private void buttonINSERT_Click(object sender, EventArgs e)
        {



            if (!listBoxCIBLE.Items.Contains(comboBoxSOURCE.Text) && comboBoxSOURCE.Text != "")
            {
                listBoxCIBLE.Items.Add(comboBoxSOURCE.Text);
                comboBoxSOURCE.Items.Remove(comboBoxSOURCE.Text);
            }
            
        }
        //INSERTALL....
        private void buttonINSERTALL_Click(object sender, EventArgs e)
        {
            Object[] monTab = new object[comboBoxSOURCE.Items.Count];

            comboBoxSOURCE.Items.CopyTo(monTab, 0);

            listBoxCIBLE.Items.AddRange(monTab);
            
        }




        private void comboBoxSOURCE_DropDown(object sender, EventArgs e)
        {
            if (comboBoxSOURCE.Items.Count > 0)
            {
                buttonINSERT.Enabled = true;
            }
            else
            {
                buttonINSERT.Enabled = false;
            }
           
        }

        
    }
}
