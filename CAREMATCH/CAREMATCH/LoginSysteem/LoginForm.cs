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
        BeheerdersForm beheerdersform;
        Beheerder gebruiker;
        Vrijwilliger vrijwilliger;
        Hulpbehoevende hulpbehoevende;
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
            
            Image piet = CAREMATCH.Properties.Resources.users;

            if (txtGebruikersnaam.Text == "" || txtWachtwoord.Text == "")
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
            else if (database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text) == null)
            {
                MessageBox.Show("Gebruikersnaam of Wachtwoord incorrect");
            }
            else if (database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "beheerder")
            {
                homeForm = new HomeForm(database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text));
                ShowDialogMethod();
            }
            else if (database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "vrijwilliger")
            {
                homeForm = new HomeForm(database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text));
                ShowDialogMethod();
            }
            else if (database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text).Rol.ToLower() == "hulpbehoevende")
            {
                homeForm = new HomeForm(database.Login(txtGebruikersnaam.Text, txtWachtwoord.Text));
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
            SignUp.Show();
            this.Hide();
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
    }
}
