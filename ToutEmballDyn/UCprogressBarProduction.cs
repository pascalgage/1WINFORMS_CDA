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
    public partial class UCprogressBarProduction : UserControl
    {
        public string LabelProductionAText
        {
            set => LabelProductionA.Text = value;
        }

        public int ProgressBarProdValue
        {
            set => progressBarProdA.Value = value;
        }

        public int ProgressBarProdMaximum
        {
            set => progressBarProdA.Maximum = value;
        }
        public UCprogressBarProduction()
        {
            InitializeComponent();
            
        }
    }
}
