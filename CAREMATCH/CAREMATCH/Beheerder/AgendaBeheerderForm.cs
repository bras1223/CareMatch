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
    public partial class AgendaBeheerderForm : Form
    {
        private Gebruiker gebruiker;
        private Database database;
        HomeForm homeform;

        public AgendaBeheerderForm(Gebruiker gebruiker)
        {
            InitializeComponent();
            database = new Database();
            this.gebruiker = gebruiker;
        }


        private void cmbBeheer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            database.AgendaBeheer(cmbBeheer.Text).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
