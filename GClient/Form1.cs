using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace GClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-NQS0FEP\MSSQLSERVER01;Initial Catalog=Clients;Integrated Security=True";
            string Query = " select * from Client;";

            SqlCommand cmd = new SqlCommand(Query,cnx);
            cnx.Open();
            SqlDataReader lire = cmd.ExecuteReader();
            if (lire.HasRows == true)
            {
                this.daGVclient.Rows.Clear();
                while (lire.Read())
                    this.daGVclient.Rows.Add(lire[0], lire[1], lire[2], lire[3], lire[4]);
                cnx.Close();
            }
            else
                MessageBox.Show(" la table est vide ");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Query = "insert into Client values ("+this.
        }
    }
}