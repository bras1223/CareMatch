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
        private Database dbQuery;
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




            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "beheerder")
            {
                gebruiker = new Beheerder(textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                beheerdersform = new BeheerdersForm();
                this.Hide();
                beheerdersform.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "Beheerder")
            {
                gebruiker = new Beheerder(textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                beheerdersform = new BeheerdersForm();
                this.Hide();
                beheerdersform.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }








            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "vrijwilliger")
            {
                //vrijwilliger is nu standaard goedgekeurd, hoort niet maar is handig voor testen

                vrijwilliger = new Vrijwilliger(true, textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                homeForm = new HomeForm(vrijwilliger);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "Vrijwilliger")
            {
                //vrijwilliger is nu standaard goedgekeurd, hoort niet maar is handig voor testen

                vrijwilliger = new Vrijwilliger(true, textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                homeForm = new HomeForm(vrijwilliger);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "hulpbehoevende")
            {
                hulpbehoevende = new Hulpbehoevende(textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                homeForm = new HomeForm(hulpbehoevende);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (dbQuery.Login(textBox1.Text, textBox2.Text) == "Hulpbehoevende")
            {
                hulpbehoevende = new Hulpbehoevende(textBox1.Text, "piet", "piet", piet, "piet", vandaag);
                homeForm = new HomeForm(hulpbehoevende);
                this.Hide();
                homeForm.ShowDialog();
                if (homeForm.DialogResult == DialogResult.OK || homeForm.DialogResult == DialogResult.Cancel)
                {
                    this.Show();
                }
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
    }
}
