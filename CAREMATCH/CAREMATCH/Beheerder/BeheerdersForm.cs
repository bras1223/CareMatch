using System;
using System.Data;
using System.Windows.Forms;
using CAREMATCH;
using Oracle.ManagedDataAccess.Client;

namespace Login
{
    public partial class BeheerdersForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;

        public BeheerdersForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbBeheer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            database.BAccountOverzicht(cmbBeheer.Text).Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
