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
using CAREMATCH;
using System.Data.SqlClient;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace Login
{
    public partial class BeheerdersForm : Form
    {
        private Database dbQuery;
        public BeheerdersForm()
        {
            InitializeComponent();
            dbQuery = new Database();
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //OracleCommand command = new OracleCommand("SELECT * FROM GEBRUIKER", con);
            //OracleDataReader reader = command.ExecuteReader();
            //con.Close();
            //dbQuery.ShowAccountGegevens();
            //DataTable dt = new DataTable();
            //command.Fill(dt);
            //dataGridView1.DataSource = dt;
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
