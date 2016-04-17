using System;
using System.Drawing;
using System.Windows.Forms;
using CAREMATCH;
using CAREMATCH.Gebruikers;

namespace Login
{
    partial class LoginForm : Form
    {
        private Login login;
        private Database database;
        HomeForm homeForm;
        SignupForm SignUp = new SignupForm();

        public LoginForm()
        {
            InitializeComponent();
            login = new Login();
            database = new Database();
        }
        //Logincheck
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtGebruikersnaam.Text == "" || txtWachtwoord.Text == "")
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else if (database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text) == null)
            {
                MessageBox.Show("Gebruikersnaam of Wachtwoord incorrect");
            }
            else if (database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "beheerder")
            {
                homeForm = new HomeForm(database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text));
                ShowDialogMethod();
            }
            else if (database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "vrijwilliger")
            {
                //Checken if Account approved.
                if(database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text).Approved)
                {
                    homeForm = new HomeForm(database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text));
                    ShowDialogMethod();
                }
                else
                {
                    MessageBox.Show("Uw Account is nog niet goedgekeurd door de beheerder.");
                }
            }
            else if (database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "hulpbehoevende")
            {
                homeForm = new HomeForm(database.GebruikerLogin(txtGebruikersnaam.Text, txtWachtwoord.Text));
                ShowDialogMethod();
            }
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
        //Naar registratiescherm
        private void lbRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (SignUp.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        public void ShowDialogMethod()
        {
            this.Hide();
            homeForm.ShowDialog();
            if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
