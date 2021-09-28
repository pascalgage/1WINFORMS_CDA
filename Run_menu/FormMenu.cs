using Additionneur;
using CheckBox;
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

        private void sousMenuIdentify_Click(object sender, EventArgs e)
        {
            Identity identify = new Identity();
            DialogResult reponse= identify.ShowDialog();
            if (reponse == DialogResult.OK)
            {
                // activer mes menus
                this.phase1ToolStrip.Enabled = true;
                this.phase2ToolStrip.Enabled = true;
                this.phase3ToolStrip.Enabled = true;
                this.fenetresToolStrip.Enabled = true;
            }

        }

        private void toolStripQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdd essai = new FormAdd();
            essai.ShowDialog();

        }

        private void checBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheck appli2 = new FormCheck();
            appli2.ShowDialog();
        }
    }
}
