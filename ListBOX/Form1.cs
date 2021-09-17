using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOUTON REMPLIR la List....ajoute et replace le focus dans entreetext
        private void addList_Click(object sender, EventArgs e)
        {
            
            inscritList.Items.Add(entreeText.Text);
            entreeText.Text="";
            entreeText.Focus();
        }

        private void emptyList_Click(object sender, EventArgs e)
        {
            inscritList.Items.Clear();
            entreeText.Focus();
        }


    }
}
