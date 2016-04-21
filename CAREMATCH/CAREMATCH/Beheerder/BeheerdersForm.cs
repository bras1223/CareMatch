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

        public void readdata(string query)
        {

            OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));"
            + "User ID=DBI327544; PASSWORD=CareMatch;");
            conn.Open();
            OracleDataAdapter reader = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            reader.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

        }
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbBeheer.Text == "Alles")
            {
                string query = "SELECT * FROM GEBRUIKER";
                readdata(query);
            }
            else if (cmbBeheer.Text == "Naam")
            {
                string query = "SELECT Naam FROM GEBRUIKER";
                readdata(query);
            }
            else if (cmbBeheer.Text == "Wachtwoord")
            {
                string query = "SELECT Wachtwoord FROM GEBRUIKER";
                readdata(query);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tijdelijk voor testen
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
