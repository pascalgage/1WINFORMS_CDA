using ClassLibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmballDyn
{
    public partial class UCfeutricolore : UserControl
    {

        public delegate void DelegateFeuClicke(UCfeutricolore sender);
        public event DelegateFeuClicke FeuRougeClick;
        public event DelegateFeuClicke FeuVertClick;
        public event DelegateFeuClicke FeuOrangeClick;






        public string NomProduction
        {
            set => labelNomProd.Text = value;
        }

        public UCfeutricolore()
        {
            InitializeComponent();

        }

        private void AuFeuRougeClicke()
        {
            if (FeuRougeClick != null)
            {
                FeuRougeClick(this);
            }
        }

        private void AuFeuVertClicke()
        {
            if (FeuVertClick != null)
            {
                FeuVertClick(this);
            }
        }

        private void AuFeuOrangeClicke()
        {
            if (FeuOrangeClick != null)
            {
                FeuOrangeClick(this);
            }
        }



        public void ChangerImageBoutonRouge(bool on)
       {
            if (on)
            {
                this.buttonRed.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ROUGE;
                ChangerImageBoutonOrange(false);
                ChangerImageBoutonVert(false);
            }
            else
            {
                this.buttonRed.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ROUGE_off;
            }
           
       }
        
        public void ChangerImageBoutonOrange(bool on)
        {
            if (on)
            {
                this.buttonOrange.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ORANGE;
                ChangerImageBoutonRouge(false);
                ChangerImageBoutonVert(false);
            }
            else
            {
                this.buttonOrange.BackgroundImage = global::ToutEmballDyn.Properties.Resources.ORANGE_off;
            }
        }
        public void ChangerImageBoutonVert(bool on)
        {
            if (on)
            {
                this.buttonGreen.BackgroundImage = global::ToutEmballDyn.Properties.Resources.VERT;
                ChangerImageBoutonRouge(false);
                ChangerImageBoutonOrange(false);
            }
            else
            {
                this.buttonGreen.BackgroundImage = global::ToutEmballDyn.Properties.Resources.VERT_off;
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            AuFeuRougeClicke();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            AuFeuVertClicke();
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            AuFeuOrangeClicke();
        }
    }
}
