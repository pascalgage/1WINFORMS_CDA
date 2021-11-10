using ClassLibraryValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GageWinformEcf
{
    public partial class InscriptionStagiaireForm : Form
    {
        public InscriptionStagiaireForm()
        {
            InitializeComponent();
        }

        public InscriptionStagiaireForm(string nom, string prenom, DateTime dateentree, DateTime datesortie, string section)
        {
            InitializeComponent();
            this.textBoxNom.Text = nom;
            this.textBoxPrenom.Text = prenom;
            this.textBoxDentree.Text = dateentree.ToString();
            this.textBoxDsortie.Text = datesortie.ToString();
            this.textBoxSection.Text = section;
        }

        public InscriptionStagiaireForm(Inscription _inscription) 
        : this(_inscription.Nom, _inscription.Prenom, _inscription.Dateentree, _inscription.Datesortie, _inscription.Sectionf)
        {

        }
        public bool ValidationNom()
        {
            if (Validation.IsValidName(textBoxNom.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidationPrenom()
        {
            if (Validation.IsValidName(textBoxPrenom.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidationDeDate()
        {
            //parsage des entrées...
            DateTime resultDate1;
            DateTime.TryParse(textBoxDentree.Text, out resultDate1);

            DateTime resultDate2;
            DateTime.TryParse(textBoxDsortie.Text, out resultDate2);

            if (Validation.IsValidDate(resultDate1, resultDate2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (!ValidationNom())
            {
                ok = false;
            }

            if (!ValidationPrenom())
            {
                ok = false;
            }

            if (!ValidationDeDate())
            {
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show( "VALIDATION INSCRIPTION  IMPOSSIBLE !");
            }
            else
            {
                
                MessageBox.Show("Nom: " +textBoxNom.Text+ " Date:"+textBoxDentree.Text+" Section:"+textBoxSection.Text);
                
            }
        }
    }
}
