using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Inserer des éléments dans le menu deroulant Source....
        private void comboBoxSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBoxSOURCE.Items.Add(comboBoxSOURCE.Text);
                //pour enlever le son...
                e.Handled = true;
                //pour vider le champ...
                comboBoxSOURCE.Text = "";
                
            }
            
        }
        //INSERT button...aller d'un élement de la SOURCE vers La CIBLE
        private void buttonInsert_Click(object sender, EventArgs e)
        {



            if (!listBoxCible.Items.Contains(comboBoxSOURCE.Text) && comboBoxSOURCE.Text != "")
            {
                listBoxCible.Items.Add(comboBoxSOURCE.Text);
                comboBoxSOURCE.Items.Remove(comboBoxSOURCE.Text);
                
            }
            
        }
        //Uninstall button...retour d'un élément de la CIBLE vers la SOURCE
        private void buttonUNINST_Click(object sender, EventArgs e)
        {
            if (!comboBoxSOURCE.Items.Contains(listBoxCible.SelectedItem))
            {
                comboBoxSOURCE.Items.Add(listBoxCible.Text);
                listBoxCible.Items.Remove(listBoxCible.Text);
            }
        }

        //INSERTALL....
        private void buttonInsertAll_Click(object sender, EventArgs e)
        {
            Object[] monTab = new object[comboBoxSOURCE.Items.Count];

            comboBoxSOURCE.Items.CopyTo(monTab, 0);
            listBoxCible.Items.AddRange(monTab);
            comboBoxSOURCE.Items.Clear();

        }

        //UNINSTALL   ALL de la CIBLE VERS LA SOURCE....
        private void buttonUninstallall_Click(object sender, EventArgs e)
        {
            Object[] monTabRetour = new object[listBoxCible.Items.Count];

            listBoxCible.Items.CopyTo(monTabRetour, 0);
            comboBoxSOURCE.Items.AddRange(monTabRetour);
            listBoxCible.Items.Clear();
        }

        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            //Si combobBoxSource est vide alors bouton .Enabled=false
            if (comboBoxSOURCE.Items.Count > 0)
            {
                buttonINSERT.Enabled = true;
                buttonINSERTALL.Enabled = true;
            }
            else
            {
                buttonINSERT.Enabled = false;
                buttonINSERTALL.Enabled = false;
            }
           
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedIndex >0)
            {

                int vIndex = listBoxCible.SelectedIndex;
                object vTemp = listBoxCible.SelectedItem;
                listBoxCible.Items.RemoveAt(vIndex);
                listBoxCible.Items.Insert(vIndex - 1, vTemp);
                listBoxCible.SelectedIndex = vIndex - 1;
            }

        }
        

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedIndex < listBoxCible.Items.Count - 1)
            {
                int vIndex = listBoxCible.SelectedIndex;
                object vTemp = listBoxCible.SelectedItem;
                listBoxCible.Items.RemoveAt(vIndex);
                listBoxCible.Items.Insert(vIndex + 1, vTemp);
                listBoxCible.SelectedIndex = vIndex + 1;
                
            }
        }
        private void EnableButton()
        {
            if (listBoxCible.SelectedItem != null)
            {
                buttonUP.Enabled = true;
                buttonDOWN.Enabled = true;
            }
            else
            {
                buttonUP.Enabled = false;
                buttonDOWN.Enabled = false;
            }


        }
        private void EnableButtonUninstall()
        {
            if(listBoxCible.SelectedItem != null)
            {
                buttonUninst.Enabled = true;
                buttonUninstall.Enabled = true;
            }
            else
            {
                buttonUninst.Enabled = false;
                buttonUninstall.Enabled = false;
            }
        }


        private void listBoxCIBLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
            EnableButtonUninstall();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listBoxCible.SelectedItem = null;
            EnableButtonUninstall();
        }
    }
}
