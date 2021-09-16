using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saisie_Controle
{
    public partial class TransactionAffForm : Form
    {
        public TransactionAffForm()
        {
            InitializeComponent();
        }

        public TransactionAffForm(string nom, DateTime date, decimal montant, int codePostal)
        {
            InitializeComponent();
            this.textBoxCLIENT.Text = nom;
            this.textBoxDATE.Text = date.ToString();
            this.textBoxMONTANT.Text = montant.ToString();
            this.textBoxCODEPOSTAL.Text = codePostal.ToString();
        }


        public TransactionAffForm(ClassLibraryTransaction.Transaction _transaction) : this(_transaction.Nom, _transaction.Date, _transaction.Montant, _transaction.CodePostal)
        {
            //this.textBoxCLIENT.Text = _transaction.Nom;
            //this.textBoxDATE.Text = _transaction.Date.ToString();
            //this.textBoxMONTANT.Text = _transaction.Montant.ToString();
            //this.textBoxCODEPOSTAL.Text = _transaction.CodePostal.ToString();
        }

        private void TransactionAffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
