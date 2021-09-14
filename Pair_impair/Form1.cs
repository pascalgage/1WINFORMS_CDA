using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pair_impair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tester_Click(object sender, EventArgs e)
        {
            int nombre = int.Parse(txt_nombre.Text);
            string msg = "";

            if (nombre % 2 == 0)
            {
                msg = "PAIR";
            }
            else
            {
                msg = "IMPAIR";
            }

            message.Text = msg;
        }
    }
}
