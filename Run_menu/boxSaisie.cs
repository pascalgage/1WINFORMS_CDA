using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Run_menu
{
    public partial class boxSaisie : Form
    {
        public boxSaisie()
        {
            InitializeComponent();
            
        }
        public delegate void DelegateRecevoirText(string _montexte);
        public event DelegateRecevoirText TextSaisietValide;

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (TextSaisietValide != null)
            {
                TextSaisietValide(textBoxText.Text);
            }
            this.Close();
        }
    }
}
