using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Additionneur
{
    public partial class FormAdd : Form
    {
        int somme;
        public FormAdd()
        {
            InitializeComponent();
            somme = 0;
        }
     
        private void button4_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            Int32.TryParse(send, out int num);
            somme += num;
            textBox1.Text += send;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;
            int num;
            Int32.TryParse(send, out num);
            somme += num;
            textBox1.Text += send;
        }
        //touche Calculer button
        private void button10_Click(object sender, EventArgs e)
        {
            Button chiffre = (Button)sender;
            string send = "+" + chiffre.Text;

            //Int32.TryParse(send,out int num);

            textBox1.Text += "="+somme;
        }
        //touche reset effacer
        private void button_reset_Click(object sender, EventArgs e)
        {
            
            
            somme = 0;
            textBox1.Text = somme.ToString();
        }
    }
}
