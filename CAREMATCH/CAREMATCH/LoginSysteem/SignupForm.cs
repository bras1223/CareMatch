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
            bool GebruikNaam = dbQuery.ControlleerGebruikersnaam(textBox1.Text);

            if (GebruikNaam == false)
            {
                MessageBox.Show("Gebruikersnaam bestaat al");
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Wachtwoorden zijn niet gelijk");
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Niet alles is ingevuld");
            }
            else if (comboBox1.Text == "Hulpbehoevende" && textBox2.Text == textBox3.Text && GebruikNaam == true)
            {
                dbQuery.AccountToevoegen(GebruikNum.ToString(), textBox1.Text, textBox2.Text, "Y", comboBox1.Text);
                MessageBox.Show("Account toegevoed");
            }
            else if (comboBox1.Text == "Vrijwilliger" && textBox2.Text == textBox3.Text && GebruikNaam == true)
            {
                dbQuery.AccountToevoegen(GebruikNum.ToString(), textBox1.Text, textBox2.Text, "Y", comboBox1.Text);
                MessageBox.Show("Account toegevoed");
            }

        }
        //Wachtwoord controle
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 5)
            {
                label4.Visible = true;
                label5.Visible = false;
            }
            if (textBox2.Text.Length >= 5)
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
