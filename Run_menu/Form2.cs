﻿using System;
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
    public partial class Identity : Form
    {
        public Identity()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == textBoxMdp.Text)
            {
                MessageBox.Show("Authentification réussie !");
                
            }
        }
    }
}
