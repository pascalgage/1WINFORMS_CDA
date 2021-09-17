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


        //DEPART ENTER TEXT
        private void textChoix_TextChanged(object sender, EventArgs e)
        {
            groupBoxChoix.Enabled = true;
            labelresult.Text= textchoix.Text;

        }

        //CHOIX FENETRE d'OPTIONS ACTIVE 
        private void fontcolor_CheckedChanged(object sender, EventArgs e)
        {
            if (fontcolor.Checked == false)
            {
                fontchoix.Enabled = false;
                labelresult.BackColor = default;
            }
            else
            {
                fontchoix.Enabled = true;
                
            }
           
            
        }
        private void colortext_CheckedChanged(object sender, EventArgs e)
        {
            if (colortext.Checked == false)
            {
                carachoix.Enabled = false;
            }
            else
            {
                carachoix.Enabled = true;
            }
        }

        private void majmintext_CheckedChanged(object sender, EventArgs e)
        {
            if (majmintext.Checked == false)
            {
                cassechoix.Enabled = false;
            }
            else
            {
                cassechoix.Enabled = true;
            }
        }
        //FIN CHOIX FENETRE...



        //COULEUR DU FONT DE TEXT CHOIX
        private void redcolorfont_Click(object sender, EventArgs e)
        {
            labelresult.BackColor = Color.Red;
        }
        private void greencolorfont_Click(object sender, EventArgs e)
        {
            labelresult.BackColor = Color.Green;
        }
        private void bluecolorfont_Click(object sender, EventArgs e)
        {
            labelresult.BackColor = Color.Blue;
        }
        //FIN CHOIX FONT COULEUR


        
    }
}
