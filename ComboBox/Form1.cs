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



            if (!listBoxCIBLE.Items.Contains(comboBoxSOURCE.Text) && comboBoxSOURCE.Text != "")
            {
                listBoxCIBLE.Items.Add(comboBoxSOURCE.Text);
                comboBoxSOURCE.Items.Remove(comboBoxSOURCE.Text);
            }
            
        }
        //Uninstall button...retour d'un élément de la CIBLE vers la SOURCE
        private void buttonUNINST_Click(object sender, EventArgs e)
        {
            if (!comboBoxSOURCE.Items.Contains(listBoxCIBLE.SelectedItem))
            {
                comboBoxSOURCE.Items.Add(listBoxCIBLE.Text);
                listBoxCIBLE.Items.Remove(listBoxCIBLE.Text);
            }
        }




        //INSERTALL....
        private void buttonInsertAll_Click(object sender, EventArgs e)
        {
            Object[] monTab = new object[comboBoxSOURCE.Items.Count];

            comboBoxSOURCE.Items.CopyTo(monTab, 0);
            listBoxCIBLE.Items.AddRange(monTab);
            comboBoxSOURCE.Items.Clear();

        }

        //UNINSTALL   ALL de la CIBLE VERS LA SOURCE....
        private void buttonUninstallall_Click(object sender, EventArgs e)
        {
            Object[] monTabRetour = new object[listBoxCIBLE.Items.Count];

            listBoxCIBLE.Items.CopyTo(monTabRetour, 0);
            comboBoxSOURCE.Items.AddRange(monTabRetour);
            listBoxCIBLE.Items.Clear();
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
            if (listBoxCIBLE.SelectedIndex >0)
            {
                int vIndex = listBoxCIBLE.SelectedIndex;
                object vTemp = listBoxCIBLE.SelectedItem;
                listBoxCIBLE.Items.RemoveAt(vIndex);
                listBoxCIBLE.Items.Insert(vIndex - 1, vTemp);
                listBoxCIBLE.SelectedIndex = vIndex - 1;
            }

        }
        

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxCIBLE.SelectedIndex < listBoxCIBLE.Items.Count - 1)
            {
                int vIndex = listBoxCIBLE.SelectedIndex;
                object vTemp = listBoxCIBLE.SelectedItem;
                listBoxCIBLE.Items.RemoveAt(vIndex);
                listBoxCIBLE.Items.Insert(vIndex + 1, vTemp);
                listBoxCIBLE.SelectedIndex = vIndex + 1;
            }
        }

        
    }
}
