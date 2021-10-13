using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmballV1
{
    public partial class UCpanelTypeProd : UserControl
    {

        public string NombreDeCaisseProduite { set => labelCaisseProduite.Text = value; }
       


        public string NombreDefaut {  set => labelDefautParHeure.Text = value; }
       

 
        public string NombreDefautDepuisDem { set => labelDefautDepuisDem.Text = value; }


        public UCpanelTypeProd()
        {
            InitializeComponent();
        }

        
    }
}
