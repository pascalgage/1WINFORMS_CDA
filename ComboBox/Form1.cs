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
            //verifie que la touche tapez est la touche enter
        }

        private void buttonINSERT_Click(object sender, EventArgs e)
        {
            listBoxCIBLE.Items.Add(comboBoxSOURCE.Text);
        }
    }
}
