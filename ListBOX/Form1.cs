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
            //bool ok=true;

            //for (int i = 0; i < inscritList.Items.Count; i++)
            //{
            //    if (entreeText.Text == inscritList.Items[i].ToString())
            //    {
            //        ok = false;
            //    }

            //}
            //if (ok)
            //{

            //    inscritList.Items.Add(entreeText.Text);
            //    entreeText.Text = "";
            //    entreeText.Focus();
            //}

            //si l'utilisateur entre un prénom déjà présent dans la liste, il n'entre pas dans la liste...
            if (!inscritList.Items.Contains(entreeText.Text))
            {
                inscritList.Items.Add(entreeText.Text);
                entreeText.Text = "";
                entreeText.Focus();
            }

        }

        private void emptyList_Click(object sender, EventArgs e)
        {
            inscritList.Items.Clear();
            entreeText.Focus();
        }

        private void inscritList_Click(object sender, EventArgs e)
        {
            AjouterUnItemDansLaListe();
        }

        private void AjouterUnItemDansLaListe()
        {
            int topindex = inscritList.SelectedIndex;
            int item = inscritList.SelectedIndex + 1;

            count.Text = inscritList.Items.Count.ToString();
            index.Text = topindex.ToString();
            render.Text = inscritList.Text;
        }

        private void selectList_Click(object sender, EventArgs e)
        {
            string indexElement = entindx.Text;
            int ind;
            bool ok = int.TryParse(indexElement, out ind );

            if (ok)
            {
                if (ind < inscritList.Items.Count)
                {
                    this.inscritList.SelectedIndex = ind;
                    AjouterUnItemDansLaListe();
                    errorNonumber.Clear();
                }


            }
            else
            {
                errorNonumber.SetError(entindx, "Veuillez saisir un nombre !");
            }
            
        }
    }
}
