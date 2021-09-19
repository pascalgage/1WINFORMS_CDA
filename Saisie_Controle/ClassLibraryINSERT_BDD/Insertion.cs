using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using System.Data.SqlClient;



namespace ClassLibraryINSERT_BDD
{


    public class Insertion: Form
    {
        public Insertion()
        {
            InitializeComponent();

        }



        private const string ConnectionString = ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SAISIE_FORM;Integrated " +
            "Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlConnection con = new SqlConnection(ConnectionString);
        con.Open();
            SqlCommand cmd = new SqlCommand("insert into clients values (@client_nom,@client_date,@client_montant,@client_codePostal)", con);
        cmd.Parameters.AddWithValue("@client_nom", textBoxName.Text);
            cmd.Parameters.AddWithValue("@client_date", textBoxDate.Text);
            cmd.Parameters.AddWithValue("@client_montant", textBoxMontant.Text);
            cmd.Parameters.AddWithValue("@client_codePostal", textBoxCodePostal.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTION EN BDD clients réussie!");

    }
}
