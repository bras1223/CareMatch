using System;
using System.Drawing;
using System.Windows.Forms;
using CAREMATCH;
using CAREMATCH.Gebruikers;

namespace CAREMATCH.LoginSysteem
{
    partial class LoginForm : Form
    {
        private Login login;
        private Database database;
        HomeForm homeForm; 
               

        public LoginForm()
        {
            InitializeComponent();
            login = new Login();
            database = new Database();
            ActiveControl = txtGebruikersnaam;
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
        //Naar registratiescherm
        private void lbRegister_Click_1(object sender, EventArgs e)
        {
            SignupForm SignUp = new SignupForm();
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

        private void btnRFIDLogin_Click(object sender, EventArgs e)
        {
            RFIDLogin RfidLogin = new RFIDLogin();
            RfidLogin.ShowDialog();
            if (RfidLogin.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else if(RfidLogin.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
        
        private void txtWachtwoord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
