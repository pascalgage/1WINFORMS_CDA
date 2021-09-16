using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textChoix_TextChanged(object sender, EventArgs e)
        {
            groupBoxChoix.Enabled = true;
            labelresult.Text= textchoix.Text;

        }

        private void fontcolor_CheckedChanged(object sender, EventArgs e)
        {
            
            
                fontchoix.Enabled = true;
            
           
            

            
        }
    }
}
