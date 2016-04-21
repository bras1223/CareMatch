using System;
using System.Data;
using System.Windows.Forms;
using CAREMATCH;
using Oracle.ManagedDataAccess.Client;

namespace Login
{
    public partial class GebruikerBeheer : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        HomeForm homeform;

        public GebruikerBeheer(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
        }


        private void cmbBeheer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            database.GebruikerBeheer(cmbBeheer.Text).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeform = new HomeForm(gebruiker);
            homeform.ShowDialog();
            if (homeform.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
