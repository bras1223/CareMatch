using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CAREMATCH;

namespace Login
{
    public partial class SignupForm : Form
    {
        private Database dbQuery;
        
        public SignupForm()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            dbQuery = new Database();           
        }
        //Gebruiker toevoegen
        private void button1_Click(object sender, EventArgs e)
        {
            int GebruikNum = dbQuery.ControlleerMaxGebruikerID() + 1;
            bool GebruikNaam = dbQuery.ControlleerGebruikersnaam(txtGebruikersnaam.Text);

            if (GebruikNaam == false)
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            if (txtWachtwoord.Text != txtHerhWachtwoord.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (txtGebruikersnaam.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            if (txtWachtwoord.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            else if (cbRol.Text == "Hulpbehoevende" && txtWachtwoord.Text == txtHerhWachtwoord.Text && GebruikNaam == true)
            {
                dbQuery.AccountToevoegen(GebruikNum.ToString(), txtGebruikersnaam.Text, txtWachtwoord.Text, "Y", cbRol.Text);
                MessageBox.Show("Account toegevoegd");
            }
            else if (cbRol.Text == "Vrijwilliger" && txtWachtwoord.Text == txtHerhWachtwoord.Text && GebruikNaam == true)
            {
                dbQuery.AccountToevoegen(GebruikNum.ToString(), txtGebruikersnaam.Text, txtWachtwoord.Text, "Y", cbRol.Text);
                MessageBox.Show("Account toegevoegd");
            }

        }
        //Wachtwoord controle
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtWachtwoord.Text.Length < 5)
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (txtWachtwoord.Text.Length >= 5)
            {
                label4.Visible = false;
                label5.Visible = true;
            }
        }
        //Terug naar LoginForm
        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
           LoginForm Login = new LoginForm();
           Login.Show();
        }

    }
}
