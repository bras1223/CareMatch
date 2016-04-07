using System;
using System.Drawing;
using System.Windows.Forms;
using CAREMATCH;
using System.Data.OleDb;
using Oracle.DataAccess.Client;

namespace Login
{
    partial class LoginForm : Form
    {
        private Login login;
        public Database database;
        private OleDbConnection sql;

        public LoginForm()
        {
            InitializeComponent();
            login = new Login();

            //database = new Database();
            //string Datasource = "Data Source=(DESCRIPTION="
            //    + "(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521))"
            //    + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));"
            //    + "User Id=dbi327544; Password=CareMatch;";
                        
            //sql = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;" + Datasource);
            //sql.Open();
        }

        //Logincheck
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DateTime vandaag = new DateTime();
            Image piet = CAREMATCH.Properties.Resources.users;
            HomeForm homeForm;
            Gebruiker gebruiker;
            Gebruiker vrijwilliger;
            Gebruiker hulpbehoevende;
            //login.LoginCheck(textBox1.Text, textBox2.Text, this);
            //
            //tijdelijk totdat we een datebase hebben
            //
            if (textBox1.Text == "beheerder" && textBox2.Text == "beheerder")
            {
                gebruiker = new Gebruiker(textBox1.Text, "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.beheerder);
                homeForm = new HomeForm(gebruiker);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }

            }
            else if (textBox1.Text == "vrijwilliger" && textBox2.Text == "vrijwilliger")
            {
                vrijwilliger = new Gebruiker(textBox1.Text, "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.vrijwilliger);
                homeForm = new HomeForm(vrijwilliger);
                this.Hide();
                homeForm.ShowDialog();
                if(homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (textBox1.Text == "hulpbehoevende" && textBox2.Text == "hulpbehoevende")
            {
                hulpbehoevende = new Gebruiker(textBox1.Text, "piet", "piet", piet, "piet", vandaag, true, CAREMATCH.Enum.rol.hulpbehoevende);
                homeForm = new HomeForm(hulpbehoevende);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }

        //User check
        public void AdminLogin()
        {
            //this.Hide();
            //BeheerdersForm twee = new BeheerdersForm();
            //twee.Show();
        }
        public void Userright()
        {
            //this.Hide();
            //GebruikersForm drie = new GebruikersForm();
            //drie.Show();
        }
        public void Userwrong()
        {
            //MessageBox.Show("Gebruikersnaam en/of wachtwoord verkeerd");
            //textBox2.Text = "";
        }

        //Go to register form
        private void lbRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SignUp drie = new SignUp();
            //drie.Show();
        }

        //Cursor hand
        private void lbRegister_MouseLeave(object sender, EventArgs e)
        {
            lbRegister.Cursor = Cursors.Default;
        }
        private void lbRegister_MouseEnter(object sender, EventArgs e)
        {
            lbRegister.Cursor = Cursors.Hand;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.database.AccountToevoegen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = database.HulpvraagAanpassen().ToString();
        }
    }
}
