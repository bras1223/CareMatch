using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAREMATCH;

namespace CAREMATCH.Beheerder
{
    public partial class ChatBeheerderForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        HomeForm homeform;
        public ChatBeheerderForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
        }


        private void cmbBeheer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            database.ChatBeheer(cmbBeheer.Text).Fill(dt);
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
