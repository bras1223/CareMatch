using System;
using System.Drawing;
using System.Windows.Forms;
using CAREMATCH;

namespace Login
{
    partial class LoginForm : Form
    {
        private Login login;
        private Database dbQuery;
        HomeForm homeForm;
        Gebruiker gebruiker;
        Gebruiker vrijwilliger;
        Gebruiker hulpbehoevende;
        SignupForm SignUp = new SignupForm();

        public LoginForm()
        {
            InitializeComponent();
            login = new Login();
            dbQuery = new Database();
        }

        //Logincheck
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DateTime vandaag = new DateTime();
            Image piet = CAREMATCH.Properties.Resources.users;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "")
            {
                MessageBox.Show("Gebruikersnaam of Wachtwoord incorrect");
            }
            else if(dbQuery.Login(textBox1.Text, textBox2.Text) == "beheerder")
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
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "vrijwilliger")
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
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "hulpbehoevende")
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbRegister_Click_1(object sender, EventArgs e)
        {
           
            SignUp.Show();
            this.Hide();
        }
    }
}
