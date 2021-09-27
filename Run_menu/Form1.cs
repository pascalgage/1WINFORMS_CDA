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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue");
            toolStripConnexion.Enabled = true;
            toolStripPhase1.Enabled = true;
            toolStripPhase2.Enabled = true;
            toolStripPhase3.Enabled = true;
            toolStripFenetres.Enabled = true;
        }

        private void sousMenuTutuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
