﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOMME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nb1 = int.Parse(textBox1.Text);
            int nb2 = int.Parse(textBox2.Text);

            int somme = nb1 + nb2;

            textBox3.Text = somme.ToString();
        }
    }
}
