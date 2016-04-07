using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class BeheerdersForm : Form
    {
        public BeheerdersForm()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ferry\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Alles")
            {
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Login", sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Close();
            }
            else if (comboBox1.Text == "Naam")
            {
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select USERNAME From Login", sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Close();
            }
            else if (comboBox1.Text == "Wachtwoord")
            {
                sql.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select PASSWORD From Login", sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sql.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
