using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace GClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-NQS0FEP\MSSQLSERVER01;Initial Catalog=Clients;Integrated Security=True");
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(" select * from Client", cnx);
            adapter.Fill(ds, "Client");
            daGVclient.DataSource = ds.Tables["Client"];
            cnx.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++)
            {
                position = this.daGVclient.CurrentRow.Index;
                id = int.Parse(this.daGVclient.Rows[position].Cells[0].Value.ToString());
                if (textBox4.Text == ds.Tables["Client"].Rows[1][0].ToString()) ;
                cpt = 1;
                break;
            }
            if (cpt == -1)
            {
                MessageBox.Show("aucun enregistrement");

            }
            else
            {
                ds.Tables["Client"].Rows[position][1] = textBox4.Text;
                ds.Tables["Client"].Rows[position][2] = textBox3.Text;
                ds.Tables["Client"].Rows[position][3] = inputad.Text;
                ds.Tables["Client"].Rows[position][4] = textBox2.Text;
                cpt = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlDataAdapter adapter = new SqlDataAdapter( "select * from CLient",cnx);
            SqlCommandBuilder enr = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Client");
            cnx.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow ligne;
            ligne = ds.Tables["Client"].NewRow();
            ligne["Nom"] = textBox4.Text;
            ligne["Prénom"] = textBox3.Text;
            ligne["ville"] = inputad.Text;
            ligne["Adresse"] = textBox2.Text;
            ds.Tables["Client"].Rows.Add(ligne);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputad_TextChanged(object sender, EventArgs e)
        {

        }
        int cpt = -1;
        int id,position;
        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++)
            {
                position = this.daGVclient.CurrentRow.Index;
                id = int.Parse(this.daGVclient.Rows[position].Cells[0].Value.ToString());
                if (textBox4.Text == ds.Tables["Client"].Rows[i][0].ToString()) ;
                cpt = 1;
                break;
            }

            if (cpt == -1)
            {
                MessageBox.Show("aucun enregistrement");

            }
            else
            {
                ds.Tables["Client"].Rows[position].Delete();
            }

        }
    }
}